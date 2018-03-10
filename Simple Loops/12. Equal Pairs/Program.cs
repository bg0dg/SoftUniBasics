using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n - pairs: ");

            int nPair = int.Parse(Console.ReadLine());

            int sum = 0;
            int diff = 0;


            for (int i = 1; i <= nPair; i++)
            {
                int input = int.Parse(Console.ReadLine());

                int inputSum = input + int.Parse(Console.ReadLine());

                if (i > 1)
                {
                    diff = Math.Abs(inputSum - sum); 
                }

                sum = inputSum;
            }

            if (diff == 0) Console.WriteLine("Yes, value " + sum);
            else Console.WriteLine("No, maxdiff=" + diff);
        }
    }
}
