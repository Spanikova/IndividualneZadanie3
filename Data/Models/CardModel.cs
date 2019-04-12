using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class CardModel
    {
        public int CardID { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public DateTime ExpDate { get; set; }
        public bool IsBlocked { get; set; }
        public string PIN { get; set; }
        public string BankAccount { get; set; }
    }
}

