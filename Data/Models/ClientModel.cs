﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Models
{
    public class ClientModel
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string BirthNumber { get; set; }
        public string IdCardNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public BankAccountModel BankAccount = new BankAccountModel();
    }
}

