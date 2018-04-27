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
            var regex = new Regex(@"[^a-zA-Z\d\s]");   // do poprawy -> a-z A-Z
            Match match = regex.Match(password);

            if (match.Success)
            {            
                Console.WriteLine("4 special");
            }
            else
                throw new Exception("Brak specjalnych znaków");
        }
    }
}
