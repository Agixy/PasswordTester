using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LevelBuilders;
using PasswordTester.Tests;

namespace PasswordTester
{
    public class Level1Factory : LevelFactory
    {
        private const int minLenghOfPassword = 5;

        public Level1Factory()
        {
            testsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(minLenghOfPassword)
                .AddNotPopularPasswordTest()
                .Build();
      
        }
    }
}
