using PasswordTester.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{
    public class TestingFlow
    {
        //private readonly IUserComunication userCom;

        public void Flow()
        {
            do
            {
                var user = new UserComunication();
                string password = user.EnterPassword();

                try
                {
                    var minLenght = new MinimumLengthTest(5);
                    bool a = minLenght.CheckCondition(password);

                    var digitInside = new DigitInsideTest();
                    bool b = digitInside.CheckCondition(password);
                }
                catch(Exception e)
                {
                    user.ShowMessage(e.Message);
                }

            } while (true);
        }


    }
}
