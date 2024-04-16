using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class TestB : TestA
    {
        public new void paint()
        {
            base.draw();
            Console.Write("C");
            this.draw();
        }

        public new void draw()
        {
            Console.Write("D");
        }

    }
}
