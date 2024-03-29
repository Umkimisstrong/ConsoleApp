using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            A m = new ConsoleApplication9.A();

            m.a = 100;          // A 의 a = 100
            func1(m);           // A 의 a = 1000
            m.b = m.a;          // A 의 b 는 1000
            func2(m);           // A 의 a = 1000+1000 = 2000

            Console.WriteLine(m.a); // 2000

        }

        static void func1(A m)
        {
            m.a *= 10;
        }

        static void func2(A m)
        {
            m.a += m.b;
        }
    }
}
