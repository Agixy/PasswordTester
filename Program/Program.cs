using PasswordTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj hasło");            // -> uzytkownik ma wybierac
            string password = Console.ReadLine();

            Console.WriteLine("Jaki poziom hasła chcesz spradzić?");
            int lvl = int.Parse(Console.ReadLine());

            switch (lvl)
            {
                case 1:
                    new Level1F
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
            }
                
                                                        
            builder.CreateChainOfTests(1);  // poszczegolne poziomy hasła
            //builder.CreateChainOfTests(2);
            //builder.CreateChainOfTests(3);



            Console.WriteLine("aaa");

            //var flow = new TestingFlow();     // robic to? -> nie

            //flow.Flow();

        }
    }
}
