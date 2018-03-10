using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rectangle side a:");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input rectangle side b:");
            var b = double.Parse(Console.ReadLine());
            var c = a * b;
            Console.WriteLine("Rectangle area is: " + c);
        }
    }
}
