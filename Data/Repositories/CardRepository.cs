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
                command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = CardLogic.GenerateCardNum() ;
                command.Parameters.Add("@expDate", SqlDbType.DateTime).Value = DateTime.Now.Add(TimeSpan.FromDays(1095)).ToShortDateString() ;
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

    }
}
