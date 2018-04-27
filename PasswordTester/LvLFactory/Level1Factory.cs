using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LevelBuilders;

namespace PasswordTester
{
    public class Level1Factory : LevelFactory
    {
        Builder builder = new Builder(minLenghOfPassword);

        private const int passlevel = 1;

        private const int minLenghOfPassword = 5;

        public Level1Factory(string password)
        {

            builder.CreateChainOfTests(passlevel);

            try
            {
                builder.Tests[0].CheckCondition(password);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
        }
    }
}
