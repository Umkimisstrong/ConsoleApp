using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string rrn = "821120-2063814";
            Console.WriteLine(rrn);
            rrn = rrn.Replace("|^@~n~@^|", "\r\n");
            Console.WriteLine(rrn);
            Console.WriteLine(rrn+ " 1");

        }
    }
}
