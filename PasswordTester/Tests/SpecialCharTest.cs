using System.Text.RegularExpressions;

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
