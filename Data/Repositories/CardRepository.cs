using Card.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Repositories
{
    public class CardRepository : MainRepository
    {
        /// <summary>
        /// Inserts new random card into database.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public bool InsertNewCard(int accountId)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
                string sqlQuery = @"INSERT INTO Cards (CardNumber, ExpDate, IsBlocked, PIN, AccountID)
                                    VALUES (@cardNumber, @expDate, 0, @pin, @accountID);";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = CardLogic.GenerateCardNum();
                command.Parameters.Add("@expDate", SqlDbType.DateTime).Value = DateTime.Now.Add(TimeSpan.FromDays(1095)).ToShortDateString();
                command.Parameters.Add("@pin", SqlDbType.VarChar).Value = CardLogic.GeneratePIN();
                command.Parameters.Add("@accountID", SqlDbType.Int).Value = accountId;
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Returns dataset of cards for selected bank account.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public DataSet GetCardsByAccId(int accountId)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return ds;
                }
                string sqlQuery = @"SELECT CardNumber AS 'Číslo', ExpDate AS 'Expirácia', IsBlocked AS 'Zablokovaná', PIN
                                    FROM Cards WHERE AccountID = @id;";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", accountId);
                    adapter.Fill(ds, "Cards");
                }
                return ds;
            }
        }

        public void UnblockCard(string cardNumber)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                string sqlQuery = @"UPDATE Cards 
                                    SET IsBlocked = 0
                                    WHERE CardNumber = @cardNum;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@cardNum", SqlDbType.Char).Value = cardNumber;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }

        public bool CheckLogin(string cardNumber, string pin)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
                string sqlQuery = @"SELECT CardID FROM Cards WHERE CardNumber = @cardNum AND PIN = @pin AND IsBlocked = 0;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@cardNum", SqlDbType.Char).Value = cardNumber;
                command.Parameters.Add("@pin", SqlDbType.Char).Value = pin;
                try
                {
                    if (command.ExecuteScalar() != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public void BlockCard(string cardNumber)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                string sqlQuery = @"UPDATE Cards 
                                    SET IsBlocked = 1
                                    WHERE CardNumber = @cardNum;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@cardNum", SqlDbType.Char).Value = cardNumber;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }

        public int getAccId(string cardNumber)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return 0;
                }
                string sqlQuery = @"SELECT AccountID FROM Cards WHERE CardNumber = @cardNumber;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@cardNumber", SqlDbType.VarChar).Value = cardNumber;
                try
                {
                    if (command.ExecuteScalar() != null)
                    {
                        return (int)command.ExecuteScalar();
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return 0;
                }
            }

        }
    }
}
