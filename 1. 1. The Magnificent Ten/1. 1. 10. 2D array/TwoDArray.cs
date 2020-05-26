using System;

namespace TwoDArray
{
    class TwoDArray
    {
        static void Main(string[] args)
        {
            Console.Write("Dimension of 2D array = ");
            int N = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, N];
            int sum = 0;

            Console.WriteLine("Fill this {0}x{1} array", N, N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++) arr[i, j] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nFilled array");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine("\nSum of even elements = " + sum);

            Console.ReadKey();
        }
    }
}
