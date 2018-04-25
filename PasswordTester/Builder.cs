using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{ 
    public class Builder
    {
        private TestsContainter testContainer;

        void CreateChainOfTests()
        {
            testContainer.testList[0].CheckNext(testContainer.testList[1]).CheckNext(testContainer.testList[2]).CheckNext(testContainer.testList[3]);
        }
    }
}
