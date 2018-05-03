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

        protected abstract string NotPassMessage { get; }

        private const string SuccessMessage = "Hasło zgodne";

        public abstract bool TestCondition(string password);

        public void SetNext(TestTemplate test)
        {
            NextTest = test;
        }

        public string StartCheckingFlow(string password)
        {
            var isPassingTest = TestCondition(password);

            if (isPassingTest && NextTest != null)
                return NextTest.StartCheckingFlow(password);

            if (isPassingTest && NextTest == null)
                return SuccessMessage;

            return NotPassMessage;
        }

    }
}
