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

                

            } while (true);
        }


    }
}
