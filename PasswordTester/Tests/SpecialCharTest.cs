using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class SpecialCharTest : TestTemplate
    {
        public override void CheckCondition(string password)
        {
            var regex = new Regex(@"[^a-zA-Z\d\s]");  
            Match match = regex.Match(password);

            if (match.Success && nextTest != null)
            {
                nextTest.CheckCondition(password);
            }
            else if (match.Success && nextTest == null)
                Console.WriteLine("Hasło zgodne");
            else
                throw new Exception("Brak specjalnych znaków");
        }
    }
}
