namespace PasswordTester.TestsExecutors
{
    internal class TestsExecutorLvl1 : TestsExecutor
    {
        private const int minLenghOfPassword = 5;

        public TestsExecutorLvl1()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(minLenghOfPassword)
                .AddNotPopularPasswordTest()
                .Build();
      
        }
    }
}
