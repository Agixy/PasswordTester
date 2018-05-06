using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester;

namespace PasswordTester.LvlFactory
{
    public class TestsExecutorLvl3 : TestsExecutor
    {
        private const int minLenghOfPassword = 12;

        public TestsExecutorLvl3()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(minLenghOfPassword)
                .AddNotPopularPasswordTest()
                .AddDigitInsideTest()
                .AddSpecialChalTest()
                .Build();
        }
    }
}
