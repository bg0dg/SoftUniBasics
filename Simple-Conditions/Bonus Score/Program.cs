using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter integer number: ");
            var num = int.Parse(Console.ReadLine());

            var bonus = 0.0;

            if (num <= 100)
            {
                bonus += 5;
            }

            else if (num > 100 && num < 1000)
            {
                bonus = num * 0.2;
            }

            else if (num > 1000)
            {
                bonus = num * 0.1;
            }

            if (num % 2 == 0.0)
            {
                bonus += 1;
            }

            if (num % 10 == 5.0)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);


        }
    }
}
