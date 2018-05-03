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

        protected override string NotPassMessage => "Hasło za krotkie";

        public MinimumLengthTest(int minLenght)
        {
            MinLenght = minLenght;
        }

        public override bool TestCondition(string password)
        {
            return password.Length > MinLenght;
        }   
    }
}
