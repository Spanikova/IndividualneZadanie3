using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ClientRepository
    {
        private const string CONNECTION_STRING = @"Server = TRANSFORMER6\SQLEXPRESS2017; Database  = TransformerBank; Trusted_Connection = True";

        public ClientModel Client = new ClientModel();
        public int SelectedId = 0;


        public int FindClientIdByText(string text)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                string sqlQuery = @"SELECT C.ClientId  
                                   FROM Clients AS C 
                                   INNER JOIN BankAccounts AS A ON C.ClientID = A.ClientID
                                   WHERE C.IdCardNumber = @text OR A.IBAN = @text OR Surname = @text";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;
                int id = int.Parse(command.ExecuteScalar().ToString());
                return id;
            }
        }

        public ClientModel FindClientById(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                string sqlQuery = @"SELECT C.ClientID, C.Name, C.Surname, C.Title, c.BirthNumber, C.IdCardNumber, C.Street, C.StreetNumber, 
                                    C.City, C.PostalCode, C.PhoneNumber, C.EmailAddress, A.AccountID, A.AccountName, A.IBAN, A.OpeningDate, 
                                    A.AccountBalance, A.AuthOverdraftLimit 
                                    FROM Clients AS C 
                                    INNER JOIN BankAccounts AS A ON C.ClientID = A.ClientID
                                    WHERE C.ClientID = @id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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
                        Client.StreetNumber = reader.GetString(7);
                        Client.City = reader.GetString(8);
                        Client.PostalCode = reader.GetString(9);
                        Client.PhoneNumber = reader.GetString(10);
                        Client.EmailAddress = reader.GetString(11);
                        Client.BankAccount.AccountID = reader.GetInt32(12);
                        Client.BankAccount.AccountName = reader.GetString(13);
                        Client.BankAccount.IBAN = reader.GetString(14);
                        Client.BankAccount.OpeningDate = reader.GetDateTime(15);
                        Client.BankAccount.AccountBalance = reader.GetDecimal(16);
                        Client.BankAccount.AuthOverdraftLimit = reader.GetDecimal(17);
                    }
                }
                return Client;
            }
        }
    }
}


//string sqlQuery = @"SELECT C.ClientID, C.Name, C.Surname, C.Title, c.BirthNumber, C.IdCardNumber, C.Street, C.StreetNumber, 
//                                    C.City, C.PostalCode, C.PhoneNumber, C.EmailAddress, A.AccountID, A.AccountName, A.IBAN, A.OpeningDate, 
//                                    A.AccountBalance, A.AuthOverdraftLimit
//                                    


//using (SqlDataReader reader = command.ExecuteReader())
//            {
//                if (reader.Read())
//                {
//                    Client.ClientID = reader.GetInt32(0);
//                    Client.Name = reader.GetString(1);
//                    Client.Surname = reader.GetString(2);
//                    Client.Title = reader.GetString(3);
//                    Client.BirthNumber = reader.GetString(4);
//                    Client.IdCardNumber = reader.GetString(5);
//                    Client.Street = reader.GetString(6);
//                    Client.StreetNumber = reader.GetString(7);
//                    Client.City = reader.GetString(8);
//                    Client.PostalCode = reader.GetString(9);
//                    Client.PhoneNumber = reader.GetString(10);
//                    Client.EmailAddress = reader.GetString(11);
//                    Client.BankAccount.AccountID = reader.GetInt32(12);
//                    Client.BankAccount.AccountName = reader.GetString(13);
//                    Client.BankAccount.IBAN = reader.GetString(14);
//                    Client.BankAccount.OpeningDate = reader.GetDateTime(15);
//                    Client.BankAccount.AccountBalance = reader.GetDecimal(16);
//                    Client.BankAccount.AuthOverdraftLimit = reader.GetDecimal(17);
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }                    