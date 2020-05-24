using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            if (!(N < 1))
            {
                for (int i = 1; i < N + 1; i++)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }

            else Console.WriteLine("Incorrect value");

            Console.ReadKey();
        }
    }
}
