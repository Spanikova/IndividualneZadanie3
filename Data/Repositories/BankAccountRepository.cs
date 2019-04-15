using Card.Models;
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
    public class BankAccountRepository : MainRepository
    {

        /// <summary>
        /// Updates bank account info in database.
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool UpdateBankAccount(BankAccountModel account)
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
                string sqlQuery = @"UPDATE BankAccounts 
                                    SET AccountName = @accountName, AuthOverdraftLimit = @limit
                                    WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@accountName", SqlDbType.NVarChar).Value = account.AccountName;
                command.Parameters.Add("@limit", SqlDbType.Decimal).Value = account.AuthOverdraftLimit;
                command.Parameters.Add("@id", SqlDbType.Int).Value = account.AccountID;
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
        /// Inserts new bank account into database.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool InsertBankAccount(ClientModel client)
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
                string sqlQuery = @"INSERT INTO BankAccounts (ClientID, AccountName, IBAN, OpeningDate, AccountBalance, AuthOverdraftLimit)
                                    VALUES (@clientId, @accName, @iban, GetDate(), @balance, @limit);";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@clientId", SqlDbType.Int).Value = client.ClientID;
                command.Parameters.Add("@accName", SqlDbType.NVarChar).Value = client.BankAccount.AccountName;
                command.Parameters.Add("@iban", SqlDbType.NVarChar).Value = client.BankAccount.Iban;
                command.Parameters.Add("@balance", SqlDbType.Decimal).Value = client.BankAccount.AccountBalance;
                command.Parameters.Add("@limit", SqlDbType.Decimal).Value = client.BankAccount.AuthOverdraftLimit;
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
        /// Sets closing date in database to current date.
        /// </summary>
        /// <param name="id"></param>
        public void CloseAccount(int id)
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
                string sqlQuery = @"UPDATE BankAccounts 
                                    SET ClosingDate = GETDATE()
                                    WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public DataSet GetAllAccounts(string iban, string surname)
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
                string sqlQuery = @"SELECT A.AccountID AS 'ID', A.IBAN AS 'IBAN', A.AccountName AS 'Názov účtu', A.OpeningDate AS 'Otvorený', 
                                    A.AccountBalance AS 'Zostatok', A.AuthOverdraftLimit AS 'Limit prečerpania',
                                    C.ClientID AS 'ID klienta', C.Name AS 'Meno', C.Surname AS 'Priezvisko', C.Title AS 'Titul', C.IdCardNumber AS 'Číslo OP'
                                    FROM BankAccounts AS A 
                                    INNER JOIN Clients AS C ON A.ClientID = C.ClientID
                                    WHERE A.IBAN LIKE @iban AND C.Surname LIKE @surname AND ClosingDate IS NULL; ";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@iban", $"%{iban}%");
                    adapter.SelectCommand.Parameters.AddWithValue("@surname", $"%{ surname}%");
                    adapter.Fill(ds, "BankAccounts");
                }
                return ds;
            }
        }

        public void AddMoney(int id, decimal money)
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
                string sqlQuery = @"UPDATE BankAccounts 
                                    SET AccountBalance = (AccountBalance + @money)
                                    WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@money", SqlDbType.Decimal).Value = money;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public void SubstractMoney(int id, decimal money)
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
                string sqlQuery = @"UPDATE BankAccounts 
                                    SET AccountBalance = (AccountBalance - @money)
                                    WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@money", SqlDbType.Decimal).Value = money;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool CheckIfIdExists(int idToCheck)
        {
            int id = 0;
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
                string sqlQuery = @"SELECT AccountID FROM BankAccounts WHERE AccountID = @id AND ClosingDate IS NULL;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = idToCheck;
                try
                {
                    if (command.ExecuteScalar() != null)
                    {
                        id = (int)command.ExecuteScalar();
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                if (id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool CheckIfEnoughMoney(int idSender, decimal money)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                decimal limit = 0;
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                string sqlQuery = @"SELECT (AccountBalance + AuthOverdraftLimit) FROM BankAccounts WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = idSender;
                try
                {
                    if (command.ExecuteScalar() != null)
                    {
                        limit = (decimal)command.ExecuteScalar();
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                if (limit > money)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        public decimal ShowBalance(int id)
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
                string sqlQuery = @"SELECT AccountBalance FROM BankAccounts WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                try
                {
                    if (command.ExecuteScalar() != null)
                    {
                        return (decimal)command.ExecuteScalar();
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
