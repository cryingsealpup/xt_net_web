using System;

namespace Sum_of_numbers
{
    class SumOfNums
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int curr = 1;
            do
            {
                curr += 1;
                if (curr % 3 == 0) sum += curr;
           
                else if (curr % 5 == 0) sum += curr;

            }
            while (curr < 999);

            Console.WriteLine("Total sum = " + sum);

            Console.ReadKey();
        }
    }
}
