using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x1: ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Input y1: ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("Input x2: ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("Input y2: ");
            var y2 = double.Parse(Console.ReadLine());
            Console.Write("Input x: ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            var y = double.Parse(Console.ReadLine());


            if ((x >= x1 && x <= x2) && (y == y1 || y == y2) || (y >= y1 && y <= y2) && (x == x1 || x == x2))
            {
                Console.WriteLine("border");
            }

            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
