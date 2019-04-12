using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BankAccountModel
    {
        public int AccountID { get; set; }
        public int ClientID { get; set; }
        public string AccountName { get; set; }
        public string IBAN { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal AuthOverdraftLimit { get; set; }

    }
}

