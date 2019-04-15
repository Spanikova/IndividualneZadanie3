using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Logic
{
    public static class CardLogic
    {
        public static string GenerateCardNum()
        {
            Random random = new Random();
            string randomCardNum1 = random.Next(10000000, 99999999).ToString();
            string randomCardNum2 = random.Next(10000000, 99999999).ToString();
            return $"{randomCardNum1}{randomCardNum2}";
        }

        public static string GeneratePIN()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }
    }
}
