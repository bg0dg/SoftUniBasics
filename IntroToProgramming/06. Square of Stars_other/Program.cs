using System;
class SquareofStars
{
    static void Main(string[] args)
    {

        for (int i = 200; i <= 6000; i += 50)
        {
            Console.Beep(i, 80);
        }
    }
}