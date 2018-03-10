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
            //Console.Write("Input your birth day-month-year: ");
            string myDate = Console.ReadLine();
            string format = "dd-MM-yyyy";

            //Console.WriteLine(DateTime.Now);

            var parsedDate = DateTime.ParseExact(myDate, format, null);
            parsedDate = parsedDate.AddDays(1000 - 1);
            Console.WriteLine(parsedDate.ToString(format));


        }
    }
}
