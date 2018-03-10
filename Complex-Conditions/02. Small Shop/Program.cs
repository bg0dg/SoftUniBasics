using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input product [coffee, water, beer, sweets, peanuts]: ");
            var prod = Console.ReadLine().ToLower();

            Console.Write("Input town [Sofia, Plovdiv, Varna]: ");
            var town = Console.ReadLine().ToLower();

            Console.Write("Input quantity: ");
            var qty = double.Parse(Console.ReadLine());


            int PricePos = 0;

            double[] price = new double[5];

            if      (prod == "coffee")   PricePos = 0;
            else if (prod == "water")    PricePos = 1;
            else if (prod == "beer")     PricePos = 2;
            else if (prod == "sweets")   PricePos = 3;
            else if (prod == "peanuts")  PricePos = 4;

            double[] priceSofia     = { 0.50, 0.80, 1.20, 1.45, 1.60 };
            double[] pricePlovdiv   = { 0.40, 0.70, 1.15, 1.30, 1.50 };
            double[] priceVarna     = { 0.45, 0.70, 1.10, 1.35, 1.55 };

            double prodPrice = 0;

            if (town == "sofia")
                prodPrice = priceSofia[PricePos] * qty;

            else if (town == "plovdiv")
                prodPrice = pricePlovdiv[PricePos] * qty;

            else if (town == "varna")
                prodPrice = priceVarna[PricePos] * qty;

            Console.WriteLine(prodPrice);

        }
    }
}
