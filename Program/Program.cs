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
            var builder = new Builder();
            var testContainer = new TestsContainter();

            builder.CreateChainOfTests(testContainer.Tests);

            testContainer.Tests[0].CheckCondition("qwerty54rt");

            Console.WriteLine("aaa");

            //var flow = new TestingFlow();

            //flow.Flow();


        }
    }
}
