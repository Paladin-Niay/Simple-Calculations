using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());

            var deg = rad * 180 / Math.PI;

            Console.WriteLine("Degre = " + Math.Round(deg, 2));
        }
    }
}
