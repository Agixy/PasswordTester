using PasswordTester.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.Tests
{
    public abstract class TestTemplate
    {
        protected TestTemplate NextTest;

        public string NotPassMessage;

        protected const string SuccessMessage = "Hasło zgodne";     // private

        public abstract bool Condition(string password);

        public void SetNext(TestTemplate test)
        {
            NextTest = test;
        }

        public string StartCheckingFlow(bool condition, string notPassMessage, string password)
        {
            if (Condition(password) && NextTest != null)
                return NextTest.StartCheckingFlow(NextTest.Condition(password), NextTest.NotPassMessage, password);

            if (Condition(password) && NextTest != null)
                return SuccessMessage;

            return notPassMessage;
        }

    }
}
