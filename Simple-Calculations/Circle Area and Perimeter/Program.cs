using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input circle radius [mm]: ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = "+ Math.Round(area, 2) + " mm^2");
            Console.WriteLine("Perimeter = " + Math.Round(perimeter, 2) + " mm");
        }
    }
}
