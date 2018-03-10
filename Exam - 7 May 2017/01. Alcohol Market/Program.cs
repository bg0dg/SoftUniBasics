using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double beerQty = double.Parse(Console.ReadLine());
            double wineQty = double.Parse(Console.ReadLine());
            double rakiaQty = double.Parse(Console.ReadLine());
            double whiskyQty = double.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            double rakiaPrice = 0.5 * whiskyPrice;
            double winePrice = 0.6 * rakiaPrice;
            double beerPrice = 0.2 * rakiaPrice;

            totalPrice = whiskyPrice * whiskyQty + beerPrice * beerQty + winePrice * wineQty + rakiaPrice * rakiaQty;

            Console.WriteLine($"{totalPrice:f2}");

            //Console.WriteLine("{0:f2} leva", totalPrice);

        }
    }
}
