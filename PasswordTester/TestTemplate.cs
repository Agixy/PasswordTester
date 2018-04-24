using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{
    abstract class TestTemplate : ITestTemplate
    {
        public abstract bool CheckCondition(string password);     

    }
}
