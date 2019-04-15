using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MainRepository
    {
        /// <summary>
        /// Connection string to TRANSFORMER6 SQL Server.
        /// </summary>
        protected const string CONNECTION_STRING = @"Server = TRANSFORMER6\SQLEXPRESS2017; Database  = TransformerBank; Trusted_Connection = True";
        
        /// <summary>
        /// Connection string to localhost SQL Server.
        /// </summary>
        //protected const string CONNECTION_STRING = @"Server = localhost\SQLEXPRESS; Database  = TransformerBank; Trusted_Connection = True";

        /// <summary>
        /// User message about no connection to database.
        /// </summary>
        public const string NO_DB_CONNECTION = "Nepodarilo sa pripojiť k databáze. \nProsím, kontaktujte administrátora.";

        /// <summary>
        /// User message about no connection to database.
        /// </summary>
        public const string UNKNOWN_ERROR = "Nastala chyba. \nProsím, kontaktujte administrátora.";
    }
}
