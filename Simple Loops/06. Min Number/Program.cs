using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to check: ");
            var num = int.Parse(Console.ReadLine());

            var min = int.MaxValue;

            for (var i = 1; i <= num; i++)
            {
                Console.Write("Input a number: ");

                var newNum = int.Parse(Console.ReadLine());

                if (newNum < min)
                {
                    min = newNum;
                }
            }

            Console.WriteLine(min);
        }
    }
}