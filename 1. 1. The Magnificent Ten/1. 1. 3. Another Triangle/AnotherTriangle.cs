using System;

namespace Another_Triangle
{
    class AnotherTriangle
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            if (!(N < 1))
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int k = 1; k <= N - i; k++) Console.Write(" ");

                    for (int j = 1; j <= i * 2 - 1; j++) Console.Write("*");

                    Console.WriteLine();
                }
            }

            else Console.WriteLine("Incorrect input");

            Console.ReadKey();
        }
    }
}
