using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 13195, max_div = 0;
            int i;
            for (i = 2; i < number; i++)
            {
                if (isPrime(i) == 1 && number % i == 0) // 나누어떨어지는 수가 하나도 없고, number 자체는 나누어 떨어지는 수
                    max_div = i; 
            }

            Console.WriteLine(max_div);


        }

        /// <summary>
        /// 소수인지 아닌지
        /// </summary>
        /// <param name="number">입력숫자..</param>
        /// <returns></returns>
        static int isPrime(int number)
        {
            int i;
            for (i = 2; i < number; i++)    // 2부터시작해서 
            {
                if (number % i == 0)
                    return 0;
            }

            // number : 2
            // return : 0

            // number 3 :
            // return 1 :

            // number 4 :
            // return 0 ;

            // number 5 : 
            // return 0 ;

            // number 6 : 
            // return 0 ;
            return 1;
        }




    }
}
