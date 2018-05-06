using PasswordTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using PasswordTester.LvlFactory;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new TestExecutorFactory();

            do
            {
                Console.WriteLine("Podaj hasło");
                string password = Console.ReadLine();

                int lvl = -1;

                Console.WriteLine("Jaki poziom hasła chcesz spradzić?");
                try
                {
                    lvl = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                      Console.WriteLine(e.Message);
                }

                var testsExecutor = factory.CreateExecutor(lvl);
              
                if(testsExecutor != null)
                    Console.WriteLine(testsExecutor.ExecuteTests(password));         
                else
                {
                    Console.WriteLine("Błąd sprawdzania");  // jakis wyjatek?
                }

            } while (true);
                                                                        
        }
    }
}
