using Card.Models;
using Card.Repositories;
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
    /// <summary>
    /// Repository class for manipulating transaction data from database.
    /// </summary>
    public class TransactionRepository : MainRepository
    {
        /// <summary>
        /// Instance of TransactionModel class for storing transaction data.
        /// </summary>
        public TransactionModel Transaction = new TransactionModel();

        /// <summary>
        /// Returns Dataset containing all transactions of specified account.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetAllTransactionsByAccount(int id)
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
                string sqlQuery = @"SELECT 
                                    CASE 
                                    WHEN SenderID IS NULL THEN 'Banka'
                                    WHEN SenderID = @id THEN 'Tento účet'
                                    ELSE S.IBAN
                                    END AS 'Odosielateľ',
                                    CASE
                                    WHEN RecipientID IS NULL THEN 'Banka'
                                    WHEN RecipientID = @id THEN 'Tento účet'
                                    ELSE R.IBAN
                                    END AS'Príjemca',
                                    Amount AS 'Suma', Time AS 'Čas', 
                                    VS, SS AS 'ŠS', KS, TransMessage AS 'Správa pre príjemcu'
                                    FROM Transactions AS T
                                    LEFT JOIN BankAccounts AS S ON T.SenderID = S.AccountID
                                    LEFT JOIN BankAccounts AS R ON T.RecipientID = R.AccountID
                                    WHERE SenderID = @id OR RecipientID = @id;";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                    adapter.Fill(ds, "Transactions");
                }
                return ds;
            }
        }

        /// <summary>
        /// Returns Dataset containing all transactionst.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllTransactions()
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
                string sqlQuery = @"SELECT 
                                    CASE 
                                    WHEN SenderID IS NULL THEN 'Banka'
                                    ELSE S.IBAN
                                    END AS 'Odosielateľ',
                                    CASE
                                    WHEN RecipientID IS NULL THEN 'Banka'
                                    ELSE R.IBAN
                                    END AS'Príjemca',
                                    Amount AS 'Suma', Time AS 'Čas', 
                                    VS, SS AS 'ŠS', KS, TransMessage AS 'Správa pre príjemcu'
                                    FROM Transactions AS T
                                    LEFT JOIN BankAccounts AS S ON T.SenderID = S.AccountID
                                    LEFT JOIN BankAccounts AS R ON T.RecipientID = R.AccountID;";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    adapter.Fill(ds, "Transactions");
                }
                return ds;
            }
        }

        /// <summary>
        /// Inserts new transaction into database.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public int InsertTransaction(TransactionModel transaction)
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
                    return -1;
                }
                string sqlQuery = @"INSERT INTO Transactions (SenderID, RecipientID, Amount, Time, VS, KS, SS, TransMessage)
                                    VALUES (@senderID, @recipientID, @value, @time, @VS, @KS, @SS, @message);";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                if (transaction.SenderID == -99)
                {
                    command.Parameters.AddWithValue("@senderID", DBNull.Value);
                }
                else
                {
                    command.Parameters.Add("@senderID", SqlDbType.Int).Value = transaction.SenderID;
                }
                if (transaction.RecipientID == -99)
                {
                    command.Parameters.AddWithValue("@recipientID", DBNull.Value);
                }
                else
                {
                    command.Parameters.Add("@recipientID", SqlDbType.Int).Value = transaction.RecipientID;
                }
                command.Parameters.Add("@value", SqlDbType.Decimal).Value = transaction.Amount;
                command.Parameters.Add("@time", SqlDbType.DateTime).Value = transaction.Time;
                if (transaction.VS.Length > 0)
                {
                    command.Parameters.Add("@VS", SqlDbType.Char).Value = transaction.VS;
                }
                else
                {
                    command.Parameters.AddWithValue("@VS", DBNull.Value);
                }
                if (transaction.KS.Length > 0)
                {
                    command.Parameters.Add("@KS", SqlDbType.Char).Value = transaction.KS;
                }
                else
                {
                    command.Parameters.AddWithValue("@KS", DBNull.Value);
                }
                if (transaction.SS.Length > 0)
                {
                    command.Parameters.Add("@SS", SqlDbType.Char).Value = transaction.SS;
                }
                else
                {
                    command.Parameters.AddWithValue("@SS", DBNull.Value);
                }
                if (transaction.TransMessage.Length > 0)
                {
                    command.Parameters.Add("@message", SqlDbType.VarChar).Value = transaction.TransMessage;
                }
                else
                {
                    command.Parameters.AddWithValue("@message", DBNull.Value);
                }
                try
                {
                    return command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return -1;
                }
            }
        }
    }
}
