using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your birth day-month-year: ");
            string myDate = Console.ReadLine();
            string format = "dd-MM-yyyy";

            var parsedDate = DateTime.ParseExact(myDate, format, null);

            TimeSpan ts = DateTime.Now - parsedDate;

            int difINDays = ts.Days;
            Console.WriteLine();

            Console.WriteLine("You are on the world for " + difINDays + " days.");
            Console.WriteLine();
        }
    }
}
