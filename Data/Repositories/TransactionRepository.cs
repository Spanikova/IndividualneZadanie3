﻿using Card.Models;
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
    public class TransactionRepository : MainRepository
    {
        public TransactionModel Transaction = new TransactionModel();

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
                command.Parameters.Add("@senderID", SqlDbType.Int).Value = transaction.SenderID;
                command.Parameters.Add("@recipientID", SqlDbType.Int).Value = transaction.RecipientID;
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