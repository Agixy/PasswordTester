using PasswordTester;
using PasswordTester.LevelBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
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

            LevelFactory factory = null;

                switch (lvl)
                {
                    case 1:
                        factory = new Level1Factory();
                        break;
                    case 2:
                        factory = new Level2Factory();
                        break;
                    case 3:
                        factory = new Level3Factory();
                        break;
                }



                factory.ExecuteTests(password);

            } while (true);
                                                                        
        }
    }
}
