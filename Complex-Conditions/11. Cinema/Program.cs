using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input type of movie [Premiere, Normal, Discount]: ");
            string type = Console.ReadLine().ToLower();
            Console.Write("Input number of rows: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Input number of column: ");
            int c = int.Parse(Console.ReadLine());

            double singlePrice = 0;

            switch (type)
            {
                case "premiere":
                    singlePrice = 12.00;
                    break;
                case "normal":
                    singlePrice = 7.50;
                    break;
                case "discount":
                    singlePrice = 5.00;
                    break;                 
            }

            double totalPrice = singlePrice * r * c;

            Console.WriteLine("{0:f2} leva", totalPrice);

        }
    }
}
