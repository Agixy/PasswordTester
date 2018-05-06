using System;

namespace PasswordTester.TestsExecutors
{
    public class TestExecutorFactory
    {
        public TestsExecutor CreateExecutor(int lvl)
        {
            switch (lvl)
            {
                case 1:
                    return new TestsExecutorLvl1();
                case 2:
                    return new TestsExecutorLvl2();
                case 3:
                    return new TestsExecutorLvl3();
                default:
                    throw new NotImplementedException();
            }
        }
}
}
