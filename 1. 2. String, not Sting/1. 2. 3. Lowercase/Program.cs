using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            int LowerCaseWords = 0;

            foreach (string word in words)
            {
                if (word.Equals(word.ToLower())) LowerCaseWords++;
            }

            Console.WriteLine("Total count: " + LowerCaseWords);

            Console.ReadKey();

        }
    }
}
