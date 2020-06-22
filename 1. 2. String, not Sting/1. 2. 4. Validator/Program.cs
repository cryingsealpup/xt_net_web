using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Input the string:");
            string str = Console.ReadLine();*/
            // or test example
            string str = "я плохо учил русский язык. забываю " +
                "начинать предложения с заглавной. хорошо, что " +
                "можно написать программу!"; 
            string result = "";
            string Separators = ".!?";
            bool IsSentence = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (IsSentence && char.IsLetter(str[i]))
                {
                    result += char.ToUpper(str[i]);
                    IsSentence = false;
                }
                else result += str[i];
                if (Separators.Contains(str[i])) IsSentence = true;
            }

            Console.WriteLine("String with capitalized letters: \n" + result);

            Console.ReadKey();
        }
    }
}
