using System;

namespace No_Positive
{
    class NoPositive
    {
        static void Main(string[] args)
        {
            double[,,] arr = new double[3, 3, 3];
            Console.WriteLine("Fill the 3x3x3 array w numbers: ");
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++) 
                        arr[i, j, k] = double.Parse(Console.ReadLine());

            Console.WriteLine("This array in one line: ");

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                        Console.Write(arr[i, j, k] + " ");

            Console.WriteLine("\nNo positive: ");
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0) arr[i, j, k] = 0;
                        Console.Write(arr[i, j, k] + " ");
                    }

            Console.ReadKey();
        }
    }
}
