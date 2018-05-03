using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class NotPopularPasswordTest : TestTemplate
    {
        private string[] popularPassFile; // zabezpieczac to jakos? readonly?

        protected override string NotPassMessage => "Hasło zbyt popularne";


        public override bool TestCondition(string password)
        {
            popularPassFile = File.ReadAllLines("PopularPasswords.txt");        // tak czy ma czytać bezposrednio z internetu?

            return !popularPassFile.Contains(password);         
        }
    }
}
