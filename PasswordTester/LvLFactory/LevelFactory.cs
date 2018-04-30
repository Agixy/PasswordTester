using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.Tests;

namespace PasswordTester.LevelBuilders
{
    public abstract class LevelFactory  // interfejs
    {
        protected TestTemplate testsChainFirstElement;

        public void ExecuteTests(string password)
        {
            try
            {
                testsChainFirstElement.StartCheckingFlow(testsChainFirstElement.Condition(password), testsChainFirstElement.NotPassMessage, password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
