﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class DigitInsideTest : TestTemplate
    {

        public DigitInsideTest()
        {
            NotPassMessage = "Hasło nie zawiera cyfr w środku";
        }
        public override bool Condition(string password)
        {
            var regex = new Regex(@".*\D\d+\D.*");  
            Match match = regex.Match(password);

            return match.Success;
        }
    }
}
