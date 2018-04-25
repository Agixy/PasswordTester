using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    class NotPopularPasswordTest : TestTemplate
    {
        //protected override void CheckCondition()
        //{
        //    throw new NotImplementedException();
        //}
        public override void CheckCondition(string password)
        {
            if (true)
            {
                nextTest.CheckCondition(password);
            }
            else
                throw new Exception("Zbyt popularne hasło");
        }
    }
}
