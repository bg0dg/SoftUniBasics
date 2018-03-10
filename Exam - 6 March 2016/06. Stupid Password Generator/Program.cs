using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            var password = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <= 'a' + l-1; k++)
                    {
                        for (char m = 'a'; m <= 'a' + l-1; m++)
                        {

                            var max = Math.Max(i, j);

                            for (int x = max + 1; x <= n; x++)
                            {
                                password = $"{i}{j}{k}{m}{x} ";
                                //password = String.Format("{0}{1}{2}{3}{4} ", i, j, k, m, x);

                                Console.Write(password);
                            }

                         //   for (int x = 1; x <= n; x++)
                         //   {
                         //       if (x > i && x > j)
                         //       {
                         //           Console.Write($"{i}{j}{k}{m}{x} ");
                         //       }
                         //   }

                        }

                    }

                }

            }

        }
    }
}
