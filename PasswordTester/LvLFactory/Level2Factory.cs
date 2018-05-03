using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LvLFactory;

namespace PasswordTester.LevelBuilders
{
    public class Level2Factory : LevelFactory
    {
        private const int MinLenghOfPassword = 8;

        public Level2Factory()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(MinLenghOfPassword)
                .AddNotPopularPasswordTest()
                .AddDigitInsideTest()
                .Build();

        }
    }
}
