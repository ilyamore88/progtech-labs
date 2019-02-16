using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Greeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello, {0} {2} {1}", myName, 1, 2);
        }
    }
}
