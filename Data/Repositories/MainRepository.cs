using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MainRepository
    {
        //protected const string CONNECTION_STRING = @"Server = TRANSFORMER6\SQLEXPRESS2017; Database  = TransformerBank; Trusted_Connection = True";
        protected const string CONNECTION_STRING = @"Server = localhost\SQLEXPRESS; Database  = TransformerBank; Trusted_Connection = True";
        public const string NO_DB_CONNECTION = "Nepodarilo sa pripojiť k databáze. \nProsím, kontaktujte administrátora."; 
    }
}
