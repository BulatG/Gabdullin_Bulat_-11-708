using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = (a / 100);
            a%= 100;
            b+= (a % 10) * 10;
            b+= (a % 10) * 100;
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
