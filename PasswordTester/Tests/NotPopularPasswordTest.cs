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

        public NotPopularPasswordTest()
        {
            NotPassMessage = "Hasło zbyt popularne";
        }

        public override bool Condition(string password)
        {
            popularPassFile = File.ReadAllLines("PopularPasswords.txt");        // tak czy ma czytać bezposrednio z internetu?

            return popularPassFile.Contains(password);         
        }
    }
}
