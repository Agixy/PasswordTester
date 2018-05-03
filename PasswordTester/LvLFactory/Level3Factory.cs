using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LvLFactory;

namespace PasswordTester.LevelBuilders
{
    public class Level3Factory : LevelFactory
    {
        private const int minLenghOfPassword = 12;

        public Level3Factory()
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
