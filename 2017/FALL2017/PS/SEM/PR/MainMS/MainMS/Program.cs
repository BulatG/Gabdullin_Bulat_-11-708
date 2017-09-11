using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMS
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            b = b - a;
            a = b + a;
            b = a - b;
            Console.WriteLine((a.ToString())+  ' ' +(b.ToString()));
            Console.ReadLine();
        }
    }
}
