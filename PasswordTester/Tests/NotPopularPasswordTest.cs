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

        public override void CheckCondition(string password)
        {
            popularPassFile = File.ReadAllLines("PopularPasswords.txt");        // tak czy ma czytać bezposrednio z internetu?

            if (!popularPassFile.Contains(password) && nextTest != null)
            {
                nextTest.CheckCondition(password);
            }
            else if (!popularPassFile.Contains(password) && nextTest == null)
                Console.WriteLine("Hasło zgodne");
            else                
                throw new Exception("Hasło należy do zbyt popularnych");
        }
    }
}
