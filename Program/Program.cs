using System;
using JetBrains.Annotations;
using PasswordTester.TestsExecutors;

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

                Console.WriteLine(testsExecutor != null ? testsExecutor.ExecuteTests(password) : "Błąd sprawdzania");
            } while (true);
                                                                        
        }
    }
}
