using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.LevelBuilders
{
    class Level3Builder : LevelBuilder
    {
        private const int minLenghOfPassword = 12;

        public Level3Builder()
        {
            TestsContainter container = new TestsContainter(minLenghOfPassword);      // czy zrobić go gdzieś wcześniej?

            for (int i = 0; i < container.Tests.Length; i++)            // czy pozostałych warunkow nie sprawdzac czy sprawdzac czy sa niespelnione?
            {
                container.Tests[i].CheckNext(container.Tests[i + 1]);
            }

        }
    }
}
