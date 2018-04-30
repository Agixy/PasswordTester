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

        //public const string NotPassMessage = "Hasło zbyt krotkie";

        public MinimumLengthTest(int minLenght)
        {
            NotPassMessage = "Hasło zbyt krotkie";
            MinLenght = minLenght;
        }

        public override bool Condition(string password)
        {
            return password.Length > MinLenght;
        }   
    }
}
