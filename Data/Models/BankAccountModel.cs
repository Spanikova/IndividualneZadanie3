using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Models
{
    /// <summary>
    /// Used for storing data about bank accounts from database.
    /// </summary>
    public class BankAccountModel
    {
        /// <summary>
        /// Stores account id.
        /// </summary>
        public int AccountID { get; set; }
        /// <summary>
        /// /// <summary>
        /// Stores client id.
        /// </summary>
        /// </summary>
        public int ClientID { get; set; }
        /// <summary>
        /// /// <summary>
        /// Stores account name.
        /// </summary>
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// /// <summary>
        /// Stores IBAN.
        /// </summary>
        /// </summary>
        public string Iban { get; set; }
        /// <summary>
        /// /// <summary>
        /// Stores opening date and time of account.
        /// </summary>
        /// </summary>
        public DateTime OpeningDate { get; set; }
        /// <summary>
        /// Stores closing date and time of account
        /// </summary>
        public DateTime ClosingDate { get; set; }
        /// <summary>
        /// Stores account balance.
        /// </summary>
        public decimal AccountBalance { get; set; }
        /// <summary>
        /// Stores authorizes overdraft limit.
        /// </summary>
        public decimal AuthOverdraftLimit { get; set; }

    }
}

