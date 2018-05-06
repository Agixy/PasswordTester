namespace PasswordTester.TestsExecutors
{
    internal class TestsExecutorLvl3 : TestsExecutor
    {
        private const int MinLenghOfPassword = 12;

        public TestsExecutorLvl3()
        {
            TestsChainFirstElement = new TestChainBuilder()
                .AddMinLenghTest(MinLenghOfPassword)
                .AddNotPopularPasswordTest()
                .AddDigitInsideTest()
                .AddSpecialChalTest()
                .Build();
        }
    }
}
