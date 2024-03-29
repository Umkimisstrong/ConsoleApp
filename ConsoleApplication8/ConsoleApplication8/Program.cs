using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            Conv obj = new ConsoleApplication8.Conv(3);

            obj.a = 5;

            int b = obj.func();
            // 5 + 56 = 61
            Console.WriteLine(obj.a+ b);

        }
    }
}
