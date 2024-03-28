using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        private String  name;

        public Person(String val)
        {
            name = val;
        }

        public static String get()
        {
            return name;
        }

        public void print()
        {
            Console.WriteLine(name);
        }
    }
}
