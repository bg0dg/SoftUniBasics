using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());

            string pass = "";
            int counter = 0;

            for (int i = 1; i <= 9; i++) //a
            {
                for (int j = 1; j <= 9; j++) //b
                {
                    for (int k = 1; k <= 9; k++) //c
                    {
                        for (int l = 1; l <= 9; l++) //d
                        {
                            
                            if (i * j + k * l == controlValue && i < j && k > l)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                counter++;

                                if (counter == 4)
                                {
                                    pass = $"{i}{j}{k}{l}";
                                  //pass = String.Format("{0}{1}{2}{3}", i, j, k, l);
                                }
                            }
                        }
                    }
                } 
            }


            if (counter > 4)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {pass}");
            }
            else if (counter == 0)
            {
                Console.WriteLine("No!");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }           

        }
    }
}
