using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input X1: ");
            var x1 = double.Parse(Console.ReadLine());
            //Console.Write("Input y1: ");
            var y1 = double.Parse(Console.ReadLine());
            //Console.Write("Input X2: ");
            var x2 = double.Parse(Console.ReadLine());
            //Console.Write("Input y2: ");
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Max(x1, x2) - Math.Min(x1, x2);
            var b = Math.Max(y1, y2) - Math.Min(y1, y2);

            var area = a * b;
            var perimeter = 2 * a + 2 * b;

            Console.WriteLine($"Area of rectangle is: {area}");
            Console.WriteLine($"Perimeter of rectangle is: {perimeter}");

        }
    }
}
