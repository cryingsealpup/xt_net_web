using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0) Console.WriteLine("Incorrect values");

            else Console.WriteLine("Area = " + a * b);

            Console.ReadKey();
        }
    }
}
