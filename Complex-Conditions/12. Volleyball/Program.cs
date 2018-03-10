using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input type of year [leap or normal]: ");
            string yearType = Console.ReadLine().ToLower();

            Console.Write("Input holidays: ");
            var p = double.Parse(Console.ReadLine());

            Console.Write("Input weekends in home town: ");
            var h = double.Parse(Console.ReadLine());

            var gameWeekends = (48 - h) * 3.0 / 4;

            var gameHolidays = p * 2.0 / 3;

            var gameHome = h;

            var sum = gameWeekends + gameHolidays + gameHome;

            if (yearType == "leap") sum = sum * 1.15;
            
            Console.WriteLine(Math.Truncate(sum));
                                    
        }
    }
}
