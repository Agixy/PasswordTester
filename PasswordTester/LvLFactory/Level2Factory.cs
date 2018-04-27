using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.LevelBuilders
{
    public class Level2Factory : LevelFactory
    {
        Builder builder = new Builder(minLenghOfPassword);

        private const int passlevel = 2;

        private const int minLenghOfPassword = 8;

        public Level2Factory(string password)
        {

            builder.CreateChainOfTests(passlevel);

            try
            {
                builder.Tests[0].CheckCondition(password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
