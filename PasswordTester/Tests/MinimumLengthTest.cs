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

        public MinimumLengthTest()
        {
        }

        public override void CheckCondition(string password)
        {
            
            if (password.Length > MinLenght)
            {
                nextTest.CheckCondition(password);
            }
            else
                throw new Exception("Hasło za krotkie");



   
        }

    
    }
}
