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
            Console.WriteLine("Insert hour: ");
            var hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert minutes: ");
            var minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hour += 1;
                minutes -= 60;
            }

            if (hour > 23)
            {
                hour = 0;
            }

            if (minutes > 9)
            {
                Console.WriteLine(hour + ":" + minutes);
            }

            else
            {
                Console.WriteLine(hour + ":" + "0" + minutes);
            }



        }
    }
}
