using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());

            var F = C * 1.8 + 32;

            Console.WriteLine("F = " + F, 2);
        }
    }
}
