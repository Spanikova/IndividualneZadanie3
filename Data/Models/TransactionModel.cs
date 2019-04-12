using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class TransactionModel
    {
        public int TransactionID { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public DateTime Time { get; set; }
        public string VS { get; set; }
        public string SS { get; set; }
        public string KS { get; set; }
        public string TransMessage { get; set; }

    }
}

