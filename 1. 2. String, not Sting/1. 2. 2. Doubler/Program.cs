using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first string:");
            StringBuilder StrToDouble = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Input second string:");
            string StrDoubling = Console.ReadLine();

            for (int i = 0; i < StrToDouble.Length; i++)
                if (StrDoubling.Contains(StrToDouble[i])) {
                    StrToDouble.Insert(i, StrToDouble[i]);
                    i++;
                }

            Console.WriteLine("Result:");
            Console.WriteLine(StrToDouble);
            Console.ReadKey();
        }
    }
}
