﻿namespace PasswordTester
{
    internal interface ITestTemplate
    {
        bool CheckCondition(string password);

        TestTemplate CheckNext(TestTemplate nextTest);

    }
}