using System.Collections.Generic;
using System.Linq;
using PasswordTester.Tests;

namespace PasswordTester
{
    internal class TestChainBuilder 
    {
        public List<TestTemplate> Tests;

        internal TestChainBuilder()
        {
            Tests = new List<TestTemplate>();
        }

        public TestChainBuilder AddMinLenghTest(int passMinLenght)
        {
            Tests.Add(new MinimumLengthTest(passMinLenght));
            return this;
        }

        public TestChainBuilder AddNotPopularPasswordTest()
        {
            Tests.Add(new NotPopularPasswordTest());
            return this;
        }

        public TestChainBuilder AddDigitInsideTest()
        {
            Tests.Add(new DigitInsideTest());
            return this;
        }

        public TestChainBuilder AddSpecialChalTest()
        {
            Tests.Add(new SpecialCharTest());
            return this;
        }

        public TestTemplate Build()
        {
            for (int i = 0; i < Tests.Count-1; i++)
            {
                Tests[i].SetNext(Tests[i + 1]);
            }

            return Tests.First();
        }     
    }
}
