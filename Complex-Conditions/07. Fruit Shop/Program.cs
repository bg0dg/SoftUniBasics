using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input product [banana / apple / orange / grapefruit / kiwi / pineapple /grapes]: ");
            string prod = Console.ReadLine().ToLower();

            Console.Write("Input day [Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday]: ");
            string day = Console.ReadLine().ToLower();

            Console.Write("Input quantity: ");
            var qty = double.Parse(Console.ReadLine());

            double price = -1; 

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (prod == "banana") price = 2.5;
                else if (prod == "apple") price = 1.2;
                else if (prod == "orange") price = 0.85;
                else if (prod == "grapefruit") price = 1.45;
                else if (prod == "kiwi") price = 2.7;
                else if (prod == "pineapple") price = 5.5;
                else if (prod == "grapes") price = 3.85;

            }
            else if (day == "saturday" || day == "sunday")
            {
                if (prod == "banana") price = 2.70;
                else if (prod == "apple") price = 1.25;
                else if (prod == "orange") price = 0.90;
                else if (prod == "grapefruit") price = 1.60;
                else if (prod == "kiwi") price = 3.00;
                else if (prod == "pineapple") price = 5.60;
                else if (prod == "grapes") price = 4.20;
            }

            if (price >= 0)
                Console.WriteLine("{0:f2}", price * qty);

            else
                Console.WriteLine("error");

        }
    }
}
