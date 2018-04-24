using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester
{
    class UserComunication : IUserComunication
    {
        public string EnterPassword()
        {
            Console.WriteLine("Wpisz hasło i naciśniej Enter:");
            string password = Console.ReadLine();

            return password;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
      
    }
}
