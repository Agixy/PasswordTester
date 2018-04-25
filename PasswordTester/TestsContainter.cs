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
        public List<TestTemplate> testList { get; } = new List<TestTemplate>();

        public TestsContainter()
        {
            testList.Add(new DigitInsideTest());
            testList.Add(new MinimumLengthTest());
            testList.Add(new NotPopularPasswordTest());
            testList.Add(new SpecialCharTest());
        }
    }
}
