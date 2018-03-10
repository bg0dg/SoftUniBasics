using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int counter = 0;
            bool flag = false;

                for (int i = 1; i <= n; i++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        counter ++;
                        Console.Write(counter + " ");

                        if (counter == n)
                        {
                            flag = true;
                            break;
                        }

                    }
                Console.WriteLine();
                if (flag == true) break;
                }          
        }
    }
}
