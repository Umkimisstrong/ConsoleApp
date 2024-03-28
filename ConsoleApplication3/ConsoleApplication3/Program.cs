using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        /// <summary>
        /// 5, 4, 3, 2, 1 을 입력받아 배열에 넣고
        /// 4, 3, 2, 1, 5 를 넘겨받도록 하는 소스
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            int i;
            for (i = 0; i < 5; i++)
            {
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer))
                {
                    arr[i] = int.Parse(answer);
                }
            }

            for (i = 0; i < 5; i++)
            {
                //Console.Write(arr[i]);
                Console.Write(arr[(i+1) % 5]);
            }


        }
    }
}
