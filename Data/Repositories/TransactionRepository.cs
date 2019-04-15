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
    class TransactionRepository : MainRepository
    {
        private TransactionModel _transaction = new TransactionModel();

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
                string sqlQuery = @"INSERT INTO Transactions (SenderIban, RecipientIban, Time, VS, KS, SS, TransMessage)
                                    OUTPUT INSERTED.TransactionID
                                    VALUES (@senderIban, @recipientIban, @time, @VS, @KS, @SS, @message);";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@senderIban", SqlDbType.Char).Value = transaction.SenderIban;
                command.Parameters.Add("@recipientIban", SqlDbType.Char).Value = transaction.RecipientIban;
                command.Parameters.Add("@time", SqlDbType.DateTime).Value = transaction.Time;
                command.Parameters.Add("@VS", SqlDbType.Char).Value = transaction.VS;
                command.Parameters.Add("@KS", SqlDbType.Char).Value = transaction.KS;
                command.Parameters.Add("@SS", SqlDbType.Char).Value = transaction.SS;
                command.Parameters.Add("@message", SqlDbType.VarChar).Value = transaction.TransMessage;
                try
                {
                    return (int)command.ExecuteScalar();
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
