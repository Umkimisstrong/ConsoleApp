using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3; int k = 1;

            switch (i)
            {
                case 1: k += 1; break;
                case 2: k++;    break;
                case 3: k = 0;  break;
                case 4: k += 3; break;
                case 5: k -= 10; break;
                default: k--; break;
            }

            Console.WriteLine(k);
            
        }
    }
}
