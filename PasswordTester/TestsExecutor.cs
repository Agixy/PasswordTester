using PasswordTester.Tests;

namespace PasswordTester
{
    public abstract class TestsExecutor
    {    
        protected TestTemplate TestsChainFirstElement;

        public string ExecuteTests(string password)
        {        
              return TestsChainFirstElement.StartCheckingFlow(password);         
        }
    }
}
