using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LevelBuilders;
using PasswordTester;
using PasswordTester.Tests;

namespace PasswordTester.LvlFactory
{
    public class TestsExecutorLvl1 : TestsExecutor
    {
        private const int minLenghOfPassword = 5;

        public TestsExecutorLvl1()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(minLenghOfPassword)
                .AddNotPopularPasswordTest()
                .Build();
      
        }
    }
}
