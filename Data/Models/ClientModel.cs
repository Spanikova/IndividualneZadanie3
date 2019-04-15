using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Models
{
    /// <summary>
    /// Used for storing data about clients from database.
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// Stores client id.
        /// </summary>
        public int ClientID { get; set; }
        /// <summary>
        /// Stores client name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Stores client surname.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Stores client title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Stores client birth number.
        /// </summary>
        public string BirthNumber { get; set; }
        /// <summary>
        /// Stores client id card number.
        /// </summary>
        public string IdCardNumber { get; set; }
        /// <summary>
        /// Stores client street.
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Stores client city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Stores client phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Instance of BankAccountModel used to store info of bank account associated with client.
        /// </summary>
        public BankAccountModel BankAccount = new BankAccountModel();
    }
}

