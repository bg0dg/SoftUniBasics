using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n-numbers: ");
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = int.MaxValue;
            double OddMax = int.MinValue;
            double EvenSum = 0;
            double EvenMin = int.MaxValue;
            double EvenMax = int.MinValue;

            for (int i = 1; i<=n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += input;
                    if (input > EvenMax) EvenMax = input;
                    if (input < EvenMin) EvenMin = input;
                }
                else if (i % 2 != 0)
                {
                    OddSum += input;
                    if (input > OddMax) OddMax = input;
                    if (input < OddMin) OddMin = input;
                }

            }

            Console.WriteLine("OddSum=" + OddSum);

            if (OddSum == 0)
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + OddMin);
                Console.WriteLine("OddMax=" + OddMax);
            }

            Console.WriteLine("EvenSum=" + EvenSum);
            if (EvenSum == 0)
            {
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
            Console.WriteLine("EvenMin=" + EvenMin);
            Console.WriteLine("EvenMax=" + EvenMax);
            }
        }
    }
}
