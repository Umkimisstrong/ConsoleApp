using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        /// <summary>
        /// Static 변수 메소드는 Static이 아닌 변수를
        /// 사용하게 되면 해당 변수를 사용한 구간에 오류밑줄 생긴다.
        /// [Person 의 return name; 구문]
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person obj = new ConsoleApplication2.Person("Kim");
            obj.print();
        }
    }
}
