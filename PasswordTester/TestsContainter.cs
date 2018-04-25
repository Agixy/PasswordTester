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

        public TestsContainter()
        {
            Tests = new TestTemplate[]
            {
             new MinimumLengthTest(5),
             new DigitInsideTest(),
             new NotPopularPasswordTest(),
             new SpecialCharTest(),
            };
        }
    }
}
