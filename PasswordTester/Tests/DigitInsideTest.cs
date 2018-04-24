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
        public override bool CheckCondition(string password)
        {
            var regex = new Regex(@"\d");
            Match match = regex.Match(password);

            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
