using System;

namespace Non_negative_sum
{
    class NonNegSum
    {
        static void Main(string[] args)
        {
            Console.Write("Fill the 1D array with 10 elements = ");
            double[] arr = new double[10];
            int sum = 0;

            for (int i = 1; i < 10; i++) arr[i] = double.Parse(Console.ReadLine());

            foreach (int elem in arr)
            {
                if (elem > -1) sum += elem;
            }

            Console.Write("Sum of non-negative elements = " + sum);

            Console.ReadKey();
        }
    }
}
