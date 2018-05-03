using PasswordTester.Tests;

namespace PasswordTester.LvLFactory
{
    public abstract class LevelFactory
    {
        protected TestTemplate TestsChainFirstElement;

        public string ExecuteTests(string password)
        {        
              return TestsChainFirstElement.StartCheckingFlow(password);         
        }
    }
}
