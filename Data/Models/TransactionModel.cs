using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Models
{
    /// <summary>
    /// Used for storing data about transactions from database.
    /// </summary>
    public class TransactionModel
    {
        /// <summary>
        /// Stores transaction id.
        /// </summary>
        public int TransactionID { get; set; }
        /// <summary>
        /// Stores sender id.
        /// </summary>
        public int SenderID { get; set; }
        /// <summary>
        /// Stores recipient id.
        /// </summary>
        public int RecipientID { get; set; }
        /// <summary>
        /// Stores transaction sum.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Stores date and time of transaction.
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Stores VS.
        /// </summary>
        public string VS { get; set; }
        /// <summary>
        /// Stores SS.
        /// </summary>
        public string SS { get; set; }
        /// <summary>
        /// Stores KS.
        /// </summary>
        public string KS { get; set; }
        /// <summary>
        /// Stores transaction message for recipient.
        /// </summary>
        public string TransMessage { get; set; }

    }
}

