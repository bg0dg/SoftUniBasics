using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input h: ");
            var h = int.Parse(Console.ReadLine());
            Console.Write("Input x: ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            var y = int.Parse(Console.ReadLine());

            if (((x > 0 && x < 3 * h) && (y > 0 && y < h)) || ((x > h && x < 2 * h) && (y > 0 && y < 4 * h))) Console.WriteLine("inside");
            else if ((x > h && x < 2 * h) && (y == h)) Console.WriteLine("inside");
            else if (((x < 0 || x > 3 * h) || (y < 0 || y > h)) && ((x < h || x > 2 * h) || (y < 0 || y > 4 * h))) Console.WriteLine("outside");
            else Console.WriteLine("border");

        }
    }
}
