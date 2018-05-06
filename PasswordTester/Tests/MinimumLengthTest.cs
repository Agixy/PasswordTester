namespace PasswordTester.Tests
{
    class MinimumLengthTest : TestTemplate
    {
        private int MinLenght { get; set; }

        protected override string NotPassMessage => "Hasło za krotkie";

        public MinimumLengthTest(int minLenght)
        {
            MinLenght = minLenght;
        }

        public override bool TestCondition(string password)
        {
            return password.Length > MinLenght;
        }   
    }
}
