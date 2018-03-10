using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());
            var C = double.Parse(Console.ReadLine());
            var D = double.Parse(Console.ReadLine()); //fishing time

            var commonTime = 1 / (1 / A + 1 / B + 1 / C);

            var totalCommonTime = commonTime + commonTime * 0.15; //time with rest

            Console.WriteLine($"Cleaning time: {totalCommonTime:f2}");

            if (D > totalCommonTime)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(Math.Abs(D - totalCommonTime))} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(D - totalCommonTime))} hours.");
            }

        }
    }
}
