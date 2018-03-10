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
            Console.WriteLine("Input number to summ: ");
            var num = int.Parse(Console.ReadLine());

            var sum = 0;

            for (var i = 1; i<=num; i++)
            {
                Console.Write("Input a number: ");

                var inputNum = int.Parse(Console.ReadLine());

                sum = sum + inputNum;         
            }
           
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
