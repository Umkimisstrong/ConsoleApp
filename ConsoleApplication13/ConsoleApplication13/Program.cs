using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 == 2 ^ 1 == 1);
            Console.WriteLine(1 == 1 ^ 1 == 2);
            Console.WriteLine(1 == 1 ^ 1 == 1);
            Console.WriteLine(1 == 3 ^ 1 == 4);

            //Console.WriteLine(1 == 2 ^ 1 == 1);
            Console.WriteLine("END");
        }
    }
}
