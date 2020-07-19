using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_array
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] array = new float[] { 2, 45, 7, 234, 90, 3, 2 };
            Console.WriteLine("Elements of an array:");
            foreach (float elem in array)
                Console.Write(elem + " ");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Sum of elements: {0}", array.MakeAction(SuperArray.Sum));
            Console.WriteLine("Average: {0}", array.MakeAction(SuperArray.Average));
            Console.WriteLine("Mode: {0}", array.MakeAction(SuperArray.Mode));
        }
    }
}
