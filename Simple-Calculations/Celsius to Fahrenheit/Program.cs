using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input grad Celsius: ");
            var gC = double.Parse(Console.ReadLine());
            var gF = gC * 9 / 5 + 32;
            Console.WriteLine(gF);
        }
    }
}
