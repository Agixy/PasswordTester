using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordTester.LevelBuilders;

namespace PasswordTester
{ 
    public class Builder
    {

        public void CreateChainOfTests(int level)
        {
            LevelBuilder levelBuilder = null;

            if (level == 1)     // lepiej switch case?
            {
                levelBuilder = new Level1Builder();
            }
            else if(level == 2)
            {
                levelBuilder = new Level2Builder();
            }
            else if(level == 3)
            {
                levelBuilder = new Level3Builder();
            }
            else
            {
                Console.WriteLine("błędny lvl");        // wywalic do userCom
            }
            
        }
    }
}
