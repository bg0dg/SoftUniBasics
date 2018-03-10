using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string flag = "Prime";

            //var prime = true;

            if (num < 2) flag = "Not Prime";

            else
            {
                for (int k = 2;  k <= Math.Sqrt(num); k++)
                {
                    if (num % k == 0)
                    {
                        flag = "Not Prime";
                        //prime = false;
                        break;
                    }                
                }      
            }

            Console.WriteLine(flag);



            //if (prime) Console.WriteLine("Prime");

            //else Console.WriteLine("Not prime");

        }
    }
}
