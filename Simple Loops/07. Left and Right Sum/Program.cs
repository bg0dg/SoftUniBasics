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
            Console.WriteLine("Input a number of lines to summ: ");
            var num = int.Parse(Console.ReadLine());

            var sumLeft = 0;
            var sumRight = 0;

            for (var k = 1; k <= 2; k++)
            {

                for (var i = 1; i <= num; i++)
                {

                    Console.Write("Input a number: ");

                    var inputNum = int.Parse(Console.ReadLine());

                    if (k == 1)
                    {
                        sumLeft += inputNum;
                    }
                    else if (k == 2)
                    {
                        sumRight += inputNum;
                    }

                }
            }

            var diff = Math.Abs(sumLeft - sumRight);

            if (diff == 0)
            {
                Console.WriteLine("Yes, sum = " + (sumLeft));
            }
            else
            {
                Console.WriteLine("No, diff = " + (diff));
            }
        }
    }
}
