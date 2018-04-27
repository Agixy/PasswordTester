using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordTester.LevelBuilders
{
    public class Level3Factory : LevelFactory
    {
        Builder builder = new Builder(minLenghOfPassword);

        private const int passlevel = 3;

        private const int minLenghOfPassword = 12;

        public Level3Factory(string password)
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
