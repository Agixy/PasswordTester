using PasswordTester.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{
    public abstract class TestTemplate : ITestTemplate
    {

        public abstract bool CheckCondition(string password);

        public TestTemplate CheckNext(TestTemplate nextTest)
        {
            return nextTest;
        }

    }
}
