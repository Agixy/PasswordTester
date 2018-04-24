using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class MinimumLengthTest : TestTemplate
    {
        private int MinLenght { get; set; }

        public MinimumLengthTest(int minLenght)
        {
            MinLenght = minLenght;
        }

        public override bool CheckCondition(string password)
        {
            if (password.Length < MinLenght)
            {
                throw new Exception("Hasło za krotkie");
            }
            else
                return true;

            return false; // ???? jakt o zrobic
   
        }

    
    }
}
