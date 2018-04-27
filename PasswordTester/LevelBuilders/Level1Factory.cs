using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LevelBuilders;

namespace PasswordTester
{
    class Level1Factory : LevelBuilder
    {
        private const int minLenghOfPassword = 5;

        public Level1Factory()
        {
            TestsContainter container = new TestsContainter(minLenghOfPassword);      // czy zrobić go gdzieś wcześniej?

            for (int i = 0; i < container.Tests.Length-1; i++)            // czy pozostałych warunkow nie sprawdzac czy sprawdzac czy sa niespelnione?
            {
                container.Tests[i].CheckNext(container.Tests[i+1]);
            }
            
            container.Tests[0].CheckCondition("123456");       // czy tutaj ok?
        }
    }
}
