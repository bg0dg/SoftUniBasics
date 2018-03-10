using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number of lines: ");
            var n = int.Parse(Console.ReadLine());
           
            int[] inputNumber = new int[n];

            for (int i = 0; i <= n-1; i++)
            {
                Console.Write("Input a number: ");

                inputNumber[i] = int.Parse(Console.ReadLine());
            }

            var totalSum = 0;
            var totalSumTemp = 0;
            var sumExceptCurrentValue = 0;
            var maxValue = 0;
            bool flag = true;

            for (int m = 0; m <= n-1; m++)
            {
                totalSum += inputNumber[m];

                for (int k = 0; k <= n - 1; k++)
                {
                    totalSumTemp += inputNumber[k];

                    if (maxValue < inputNumber[k])
                    {
                        maxValue = inputNumber[k];
                    }
                }

                sumExceptCurrentValue = totalSumTemp - inputNumber[m];

                if (sumExceptCurrentValue == inputNumber[m])
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + inputNumber[m]);
                    flag = false;
                }

                totalSumTemp = 0;
            }

            if (flag == true)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxValue - (totalSum - maxValue)));
            }


            /*


            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;
            int greatestNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > greatestNumber)
                {
                    greatestNumber = number;
                }
            }

            if (sum - greatestNumber == greatestNumber)
            {
                Console.WriteLine($"Yes, sum {sum - greatestNumber}");
            }
            else
            {
                Console.WriteLine($"no diff {Math.Abs(greatestNumber - (sum - greatestNumber))}");
            }

    */

        }
    }
}
