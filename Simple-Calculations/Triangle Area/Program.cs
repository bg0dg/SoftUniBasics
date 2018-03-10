using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input side a: ");
            var a = double.Parse(Console.ReadLine());
            //Console.Write("Input h: ");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(a * h / 2, 2));
        }
    }
}
