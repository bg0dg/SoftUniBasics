using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int result = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                result = result + lastDigit; 
                num = num / 10; 
            }

            Console.WriteLine(result);
        }
    }
}
