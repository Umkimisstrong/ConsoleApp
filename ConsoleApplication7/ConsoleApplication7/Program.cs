using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            A [] a = new A[2];
            

            for (int i = 0; i < 2; i++)
            {
                A instanceA = new A();
                a[i] = instanceA;

                a[i].n = i;
                a[i].g = i + 1;
            }

            /*
                1회전
                A   n = 0
                    g = 1
                
                2회전
                A   n = 1
                    g = 2
                 
            */

            Console.WriteLine(a[0].n + a[1].g);
            // 0, 2 
            // 0 + 2 = 2;
                

        }
    }
}
