using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Вариант, когато се взима 3-цифрено число и намалява с 1;

                string M = Console.ReadLine();
                string N = Console.ReadLine();
                string L = Console.ReadLine();
                int specialNr = int.Parse(Console.ReadLine());
                int controlNr = int.Parse(Console.ReadLine());

                string MNL = M + N + L;

                int MNLnum = int.Parse(MNL);

                for (int i = MNLnum; i >= 111; i--)
                {
                    if (i % 10 != 0 && ((i / 10) % 10 != 0) && ((i / 100) % 10 != 0))

                    {
                        Console.Write(i + " ");

                        if (i % 3 == 0)
                        {
                            specialNr += 5;
                        }

                        else if (i % 10 == 5)
                        {
                            specialNr -= 2;
                        }


                        else if (i % 2 == 0)
                        {
                            specialNr *= 2;
                        }

                        Console.WriteLine(specialNr + " ");

                        if (specialNr >= controlNr)
                        {
                            break;
                        }
                    }
                }

                if (specialNr >= controlNr)
                {
                    Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNr}");
                }

                else 
                {
                    Console.WriteLine($"No! {specialNr} is the last reached special number.");
                }


            */

            //Вариант, когато отделните цифри на числото намаляват с 1.

            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNr = int.Parse(Console.ReadLine());
            int controlNr = int.Parse(Console.ReadLine());

            bool breakFlag = false;

            for(int m = M; m > 0; m--)
            {            

                if (breakFlag) break;

                for (int n = N; n > 0; n--)
                {
                    if (breakFlag) break;

                    for (int l = L; l > 0; l--)
                    {
                        //int num = 100 * m + 10 * m + l;
                        int num = int.Parse($"{m}{n}{l}");

                        if (num % 3 == 0) specialNr += 5;

                        else if (l == 5) specialNr -= 2;

                        else if (num % 2 == 0) specialNr *= 2;

                        if (specialNr >= controlNr)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNr}.");
                            breakFlag = true;
                            break;
                        }
                    }
                }
            }

            if(breakFlag == false)
            {
                Console.WriteLine($"No! {specialNr} is the last reached special number.");
            }
        }
    }
}
