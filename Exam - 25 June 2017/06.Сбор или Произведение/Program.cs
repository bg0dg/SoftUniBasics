using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Сбор_или_Произведение
{
    class Program
    {
        static void Main(string[] args)
        {

            int control = int.Parse(Console.ReadLine());

            bool flag = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == control && a < b && b < c)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {control}");
                            flag = true;
                        }

                        if (a * b * c == control && a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {control}");
                            flag = true;
                        }

                    }

                }

            }

            if (flag == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
