using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Logic
{
    /// <summary>
    /// Logic class for BankAccountModel.
    /// </summary>
    public static class BankAccountLogic
    {
        /// <summary>
        /// Generates random IBAN.
        /// </summary>
        /// <returns></returns>
        public static string GenerateIBAN()
        {
            Random random = new Random();
            string randomCheckNum = random.Next(11, 99).ToString();
            string randomBank = random.Next(1000, 9999).ToString();
            string randomAccNum1 = random.Next(10000, 99999).ToString();
            string randomAccNum2 = random.Next(10000, 99999).ToString();
            return $"SK{randomCheckNum}{randomBank}000000{randomAccNum1}{randomAccNum2}";
        }
    }
}
