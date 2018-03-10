using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double counterPoor = 0.0;
            double counterSatisfactory = 0.0;
            double counterGood = 0.0;
            double counterVeryGood = 0.0;
            double counterExcellent = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double inputPoints = double.Parse(Console.ReadLine());

                if (inputPoints >= 0 && inputPoints <= 22.5) counterPoor++;
                if (inputPoints > 22.5 && inputPoints <= 40.5) counterSatisfactory++;
                if (inputPoints > 40.5  && inputPoints <= 58.5) counterGood++;
                if (inputPoints > 58.5 && inputPoints <= 76.5) counterVeryGood++;
                if (inputPoints > 76.50 && inputPoints <= 100) counterExcellent ++;

            }

            var commonCounter = counterPoor + counterSatisfactory + counterGood + counterVeryGood + counterExcellent;

            double percPoor = counterPoor / commonCounter * 100;
            Console.WriteLine($"{percPoor:f2}% poor marks");

            var percSatisfactory = counterSatisfactory / commonCounter * 100;
            Console.WriteLine($"{percSatisfactory:f2}% satisfactory marks");

            var perccounterGood = counterGood / commonCounter * 100;
            Console.WriteLine($"{perccounterGood:f2}% good marks");

            var perccounterVeryGood = counterVeryGood / commonCounter * 100;
            Console.WriteLine($"{perccounterVeryGood:f2}% very good marks");

            var perccounterExcellent = counterExcellent / commonCounter * 100;
            Console.WriteLine($"{perccounterExcellent:f2}% excellent marks");

        }
    }
}
