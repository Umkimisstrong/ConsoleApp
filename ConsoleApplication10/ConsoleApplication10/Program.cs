using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(func(5));

            int number = 1234;
            int div = 10;
            int result = 0;

            while (number > 0)
            {
                result = result * div;
                result = result + number % div;
                number = number / div;

            }

            Console.WriteLine(result);
        }

        static int func(int a)
        {
            if (a <= 1) return 1;

            return a * func(a - 1);
        }


    }
}
