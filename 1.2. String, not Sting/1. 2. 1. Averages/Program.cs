using System;
using System.Text.RegularExpressions;

namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string:");
            string str = Console.ReadLine().ToUpper();
            // or test example
            /* string str = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, " +
                "пообщался со студентами в чате".ToUpper(); */

            string[] words = Regex.Split(str, @"\W+");
            double sum = 0; // average length will be presented as double
            double WordsLen = 0;

            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
                WordsLen++;
            }

            Console.WriteLine("Average length of words (double) = " + sum/ WordsLen);
            Console.ReadKey();
        }
    }
}
