using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        /// <summary>
        /// 특정 정수에 대한 구분값을 구하는 것으로
        /// 나눗셈과 나눗셈에 대한 나머지를 통해 최소연산을 할 수 있다.
        /// 참고 : 500으로 나눈 나머지로 바로 100원 갯수를 찾는다.
        ///        100으로 나눈 나머지로 바로 10원 갯수를 찾는다.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int m = 4620;

            int a = m / 1000;     // 1000원  갯수
            int b = (m % 1000) / 500; // 500원 갯수
            int c = (m % 500) / 100; // 100원 갯수
            int d = (m % 100) / 10;

            Console.WriteLine(
                                "1000원 =" + a.ToString() + "개"
                                + "500원 =" + b.ToString() + "개"
                                + "100원 =" + c.ToString() + "개"
                                + "10원 =" + d.ToString() + "개"
                            );
            Console.Write("")
                ;



        }
    }
}
