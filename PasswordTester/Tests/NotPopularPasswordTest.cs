using System.IO;
using System.Linq;

namespace PasswordTester.Tests
{
    class NotPopularPasswordTest : TestTemplate
    {
        private string[] _popularPassFile;

        protected override string NotPassMessage => "Hasło zbyt popularne";

        public override bool TestCondition(string password)
        {
            _popularPassFile = File.ReadAllLines("PopularPasswords.txt");

            return !_popularPassFile.Contains(password);         
        }
    }
}
