using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LevelBuilders;
using PasswordTester.Tests;

namespace PasswordTester
{ 
    public class Builder 
    {
        public TestTemplate[] Tests = null;     // czy to jest potrzebne?

        public Builder(int passMinLenght)        // czy ok takie podawanie długosci.?
        {
            Tests = new TestTemplate[]
            {
                new MinimumLengthTest(passMinLenght),                   // 1 -> 1,2      2->1, 2,3      3 ->1,2,3,4
                new NotPopularPasswordTest(),
                new DigitInsideTest(),
                new SpecialCharTest(),
            };
        }

        public void CreateChainOfTests(int passLvl)
        {
            for (int i = 0; i < passLvl; i++)
            {
                Tests[i].CheckNext(Tests[i + 1]);
            }
            
        }
    }
}
