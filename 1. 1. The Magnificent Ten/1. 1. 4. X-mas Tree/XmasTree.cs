using System;

namespace XmasTree
{
    class XmasTree
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            if (!(N < 1))
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int m = 1; m <= i; m++)
                    {

                        for (int k = 1; k <= N - m; k++) Console.Write(" ");

                        for (int j = 1; j <= m * 2 - 1; j++) Console.Write("*");

                        Console.WriteLine();
                    }
                }
            }

            else Console.WriteLine("Incorrect input");

            Console.ReadKey();
        }
    }
}
