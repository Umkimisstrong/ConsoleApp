﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            TestA a = new TestB();

            a.paint();
            a.draw();

            Console.WriteLine("End");

        }
    }
}
