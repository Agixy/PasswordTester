using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.LvlFactory
{
    public class TestExecutorFactory
    {
        // metoda int i tworzy cos switch case

        public TestsExecutor CreateExecutor(int lvl)
        {
            switch (lvl)
            {
                case 1:
                    return new TestsExecutorLvl1();
                    break;
                case 2:
                    return new TestsExecutorLvl2();
                    break;
                case 3:
                    return new TestsExecutorLvl3();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
}
}
