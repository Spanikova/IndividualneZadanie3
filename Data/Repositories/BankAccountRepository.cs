using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
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
    }
}
