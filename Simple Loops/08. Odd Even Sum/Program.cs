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
            Console.WriteLine("Input a number of lines to check: ");
            var num = int.Parse(Console.ReadLine());

            var sumEven = 0;
            var sumOdd = 0;

            for (var i = 1; i <= num; i++)
            {

                Console.Write("Input a number: ");

                var inputNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += inputNum;
                }
                else if (i % 2 != 0)
                {
                    sumOdd += inputNum;
                }

            }

            var diff = Math.Abs(sumEven - sumOdd);

            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (sumEven));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + (diff));
            }
        }
    }
}
