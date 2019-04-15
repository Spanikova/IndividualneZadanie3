using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Models
{
    /// <summary>
    /// Used for storing data about cards from database.
    /// </summary>
    class CardModel
    {
        /// <summary>
        /// Stores card id.
        /// </summary>
        public int CardID { get; set; }
        /// <summary>
        /// Stores card number.
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// Stores card name.
        /// </summary>
        public string CardName { get; set; }
        /// <summary>
        /// Stores card expiration date.
        /// </summary>
        public DateTime ExpDate { get; set; }
        /// <summary>
        /// Stores info if card is blocked.
        /// </summary>
        public bool IsBlocked { get; set; }
        /// <summary>
        /// Stores card PIN.
        /// </summary>
        public string PIN { get; set; }
        /// <summary>
        /// Stores id of account associated with card.
        /// </summary>
        public string BankAccount { get; set; }
    }
}

