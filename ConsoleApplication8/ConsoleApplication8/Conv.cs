using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Conv
    {
        public int a;
        public Conv(int a)
        {
            this.a = a;
        }

        public int func()
        {
            int b = 1;
            for (int i = 0; i < a; i++)
            {
                b = a * i + b;
            }
            // if a = 5;
            // 1회전
            // b = 5 * 0 + 1 = 1

            // 2회전
            // b = 5 * 1 + 1 = 6

            // 3회전
            // b = 5 * 2 + 6 = 16

            // 4회전
            // b = 5 * 3 + 16 = 31

            // 5회전
            // b = 5 * 4 + 31 = 51


            return a + b;

            // a + b = 5 + 51 = 56
        }
    }
}
