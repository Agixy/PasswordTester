using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class DigitInsideTest : TestTemplate
    {
        public override void CheckCondition(string password)
        {
            var regex = new Regex(@"\D\d\D");           // jak to zrobic,?
            Match match = regex.Match(password);

            if (match.Success && nextTest != null)
                nextTest.CheckCondition(password);
            else if (match.Success && nextTest == null)
                Console.WriteLine("Hasło zgodne");
            else
                throw new Exception("Hasło nie zawiera cyfr w środku");
        }
    }
}
