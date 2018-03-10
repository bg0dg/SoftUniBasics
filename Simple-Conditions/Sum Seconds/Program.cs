using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter 3 times up to 50 sec.: ");
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());

            var sumTime = time1 + time2 + time3;

            int min = 0;

            int sec = 0;

            if (sumTime < 60)
            {
                min = 0;
                sec = sumTime;
            }

            else if (sumTime >= 60 && sumTime < 120)
            {
                min = 1;
                sec = sumTime - 60;
            }

            else if (sumTime >= 120 && sumTime < 180)
            {
                min = 2;
                sec = sumTime - 120;
            }

            if (sec >= 10)
            {
                Console.WriteLine(min + ":" + sec);
            }
            else
            {
                Console.WriteLine(min + ":" + "0" + sec);
            }

        }
    }
}
