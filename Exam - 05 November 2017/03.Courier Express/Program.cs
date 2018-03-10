using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double parcelWeight = double.Parse(Console.ReadLine());

            string serviceType = Console.ReadLine();

            int distanceKm = int.Parse(Console.ReadLine());

            var singlePrice = 0.00;

            if (parcelWeight < 1) singlePrice = 0.03;
            else if (parcelWeight >= 1 && parcelWeight <= 10) singlePrice = 0.05;
            else if (parcelWeight >= 11 && parcelWeight <= 40) singlePrice = 0.10;
            else if (parcelWeight >= 41 && parcelWeight <= 90) singlePrice = 0.15;
            else if (parcelWeight >= 91 && parcelWeight <= 150) singlePrice = 0.20;

            var addPrice = 0.00;

            if (serviceType == "express")
            {
                if                              (parcelWeight < 1) addPrice = 0.8 * singlePrice;
                else if (parcelWeight >= 1 && parcelWeight <= 10) addPrice = 0.4 * singlePrice;
                else if (parcelWeight >= 11 && parcelWeight <= 40) addPrice = 0.05 * singlePrice;
                else if (parcelWeight >= 41 && parcelWeight <= 90) addPrice = 0.02 * singlePrice;
                else if (parcelWeight >= 91 && parcelWeight <= 150) addPrice = 0.01 * singlePrice;

            }

            var totalCost = singlePrice * distanceKm;

            var addCost = addPrice * parcelWeight * distanceKm;

            var commonCost = totalCost + addCost;

            Console.WriteLine($"The delivery of your shipment with weight of {parcelWeight:f3} kg. would cost {commonCost:f2} lv.");

        }
    }
}
