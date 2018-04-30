using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.LevelBuilders
{
    public class Level3Factory : LevelFactory
    {
        private const int minLenghOfPassword = 12;

        public Level3Factory()
        {
            testsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(minLenghOfPassword)
                .AddNotPopularPasswordTest()
                .AddDigitInsideTest()
                .AddSpecialChalTest()
                .Build();

        }
    }
}
