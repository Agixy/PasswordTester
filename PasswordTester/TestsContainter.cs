using PasswordTester.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{
    public class TestsContainter
    {
        public TestTemplate[] Tests = null;

        public TestsContainter(int minLenghTest)        // czy ok.?
        {
            Tests = new TestTemplate[]
            {
             new MinimumLengthTest(minLenghTest),
             new DigitInsideTest(),
             new NotPopularPasswordTest(),
             new SpecialCharTest(),
            };
        }
    }
}
