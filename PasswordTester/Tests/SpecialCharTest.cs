﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class SpecialCharTest : TestTemplate
    {
        protected override string NotPassMessage => "Hasło nie zawiera znaków specjalnych";

        public override bool TestCondition(string password)
        {
            var regex = new Regex(@"[^a-zA-Z\d\s]");  
            Match match = regex.Match(password);

            return match.Success;        
        }
    }
}
