using PasswordTester.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{
    public abstract class TestTemplate
    {
        protected TestTemplate nextTest;

        public abstract void CheckCondition(string password);

        public void CheckNext(TestTemplate test)
        {
            nextTest = test;
        }

    }
}
