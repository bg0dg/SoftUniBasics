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

            Console.Write("Input a number: ");
            var max = int.Parse(Console.ReadLine());

            for (var i = 1; i <= num-1; i++)
            {
                Console.Write("Input a number: ");

                var newNum = int.Parse(Console.ReadLine());

                if (newNum > max)
                {
                    max = newNum;
                }
            }

            Console.WriteLine(max);
        }
    }
}


/*

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

            var max = int.MinValue;

            for (var i = 1; i <= num; i++)
            {
                Console.Write("Input a number: ");

                var newNum = int.Parse(Console.ReadLine());

                if (newNum > max)
                {
                    max = newNum;
                }
            }

            Console.WriteLine(max);
        }
    }
}

*/
