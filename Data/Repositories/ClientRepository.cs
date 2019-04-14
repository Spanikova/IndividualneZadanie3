using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientRepository : MainRepository
    {
        /// <summary>
        /// Instance of ClientModel class used to store data from database.
        /// </summary>
        public ClientModel Client = new ClientModel();

        /// <summary>
        /// Returns client ID from database by id card, IBAN or surname based on input text. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int FindClientIdByText(string text)
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
                string sqlQuery = @"SELECT C.ClientId  
                                   FROM Clients AS C 
                                   INNER JOIN BankAccounts AS A ON C.ClientID = A.ClientID
                                   WHERE (C.IdCardNumber = @text OR A.IBAN = @text OR C.Surname = @text) AND A.ClosingDate IS NULL";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;
                try
                {
                    object queryResult = command.ExecuteScalar();
                    if (queryResult != null)
                    {
                        return (int)queryResult;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return -1;
                }
            }
        }

        /// <summary>
        /// Finds info about client and bank account in database based on input id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClientModel FindClientById(int id)
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
                string sqlQuery = @"SELECT C.ClientID, C.Name, C.Surname, C.Title, c.BirthNumber, C.IdCardNumber, C.Street,
                                    C.City, C.PhoneNumber, A.AccountID, A.AccountName, A.IBAN, A.OpeningDate, 
                                    A.AccountBalance, A.AuthOverdraftLimit, A.ClosingDate
                                    FROM Clients AS C 
                                    INNER JOIN BankAccounts AS A ON C.ClientID = A.ClientID
                                    WHERE C.ClientID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Client.ClientID = reader.GetInt32(0);
                            Client.Name = reader.GetString(1);
                            Client.Surname = reader.GetString(2);
                            Client.Title = reader.GetString(3);
                            Client.BirthNumber = reader.GetString(4);
                            Client.IdCardNumber = reader.GetString(5);
                            Client.Street = reader.GetString(6);
                            Client.City = reader.GetString(7);
                            Client.PhoneNumber = reader.GetString(8);
                            Client.BankAccount.AccountID = reader.GetInt32(9);
                            Client.BankAccount.AccountName = reader.GetString(10);
                            Client.BankAccount.Iban = reader.GetString(11);
                            Client.BankAccount.OpeningDate = reader.GetDateTime(12);
                            Client.BankAccount.AccountBalance = reader.GetDecimal(13);
                            Client.BankAccount.AuthOverdraftLimit = reader.GetDecimal(14);
                            if (reader.IsDBNull(15))
                            {
                            }
                            else
                            {
                                Client.BankAccount.ClosingDate = reader.GetDateTime(15);
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                }
                return Client;
            }
        }

        /// <summary>
        /// Updates client info in database.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool UpdateClient(ClientModel client)
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
                int id = client.ClientID;
                string name = client.Name;
                string surname = client.Surname;
                string title = client.Title;
                string birthNumber = client.BirthNumber;
                string idCard = client.IdCardNumber;
                string street = client.Street;
                string city = client.City;
                string phoneNumber = client.PhoneNumber;
                string sqlQuery = @"UPDATE Clients 
                                    SET Name = @name, Surname = @surname, Title = @title, BirthNumber = @birthNumber, 
                                        IdCardNumber = @idCard, Street = @street, City = @city, PhoneNumber = @phoneNumber
                                    WHERE CLientID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = surname;
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                command.Parameters.Add("@birthNumber", SqlDbType.NVarChar).Value = birthNumber;
                command.Parameters.Add("@idCard", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("@street", SqlDbType.NVarChar).Value = street;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
                command.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
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


