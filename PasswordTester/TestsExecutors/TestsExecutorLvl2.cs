namespace PasswordTester.TestsExecutors
{
    internal class TestsExecutorLvl2 : TestsExecutor
    {
        private const int MinLenghOfPassword = 8;

        public TestsExecutorLvl2()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(MinLenghOfPassword)
                .AddNotPopularPasswordTest()
                .AddDigitInsideTest()
                .Build();
        }
    }
}
