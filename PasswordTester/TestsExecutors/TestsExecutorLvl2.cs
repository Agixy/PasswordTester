using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester;

namespace PasswordTester.LvlFactory
{
    public class TestsExecutorLvl2 : TestsExecutor
    {
        private const int MinLenghOfPassword = 8;

        public TestsExecutorLvl2()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(MinLenghOfPassword)
                .AddNotPopularPasswordTest()
                .AddDigitInsideTest()
                .Build();

        }
    }
}
