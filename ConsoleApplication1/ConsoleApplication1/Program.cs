using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 73, 95, 82 };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
            Console.Write(sum / 30);
            //switch ()
            //{
            //    case 10:
            //    case 9:Console.Write("A");
            //        break;
            //    case 8:Console.Write("B");
            //        break;
            //    case 7:
            //    case 6:Console.Write("C");
            //    default:Console.Write("D");

            //}




        }
    }
}
