using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double h = double.Parse(Console.ReadLine());
            double priceM = double.Parse(Console.ReadLine());
            double weightM2kg = double.Parse(Console.ReadLine());

            int lengthM = 2 * a + 2 * b;

            double price = lengthM * priceM;

            double area = lengthM * h;

            double weight = area * weightM2kg;

            Console.WriteLine(lengthM);

            Console.WriteLine($"{price:f2}");

            Console.WriteLine($"{weight:f3}");

        }
    }
}
