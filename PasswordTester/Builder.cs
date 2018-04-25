using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{ 
    public class Builder
    {

        public void CreateChainOfTests(TestTemplate[] testsList)
        {
            testsList[0].CheckNext(testsList[1]);
            testsList[1].CheckNext(testsList[2]);
            testsList[2].CheckNext(testsList[3]);
        }
    }
}
