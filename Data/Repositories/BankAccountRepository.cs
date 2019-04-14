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
                string accountName = account.AccountName;
                decimal limit = account.AuthOverdraftLimit;
                string sqlQuery = @"UPDATE BankAccounts 
                                    SET AccountName = @accountName, AuthOverdraftLimit = @limit
                                    WHERE AccountID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@accountName", SqlDbType.NVarChar).Value = accountName;
                command.Parameters.Add("@limit", SqlDbType.Decimal).Value = limit;
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
