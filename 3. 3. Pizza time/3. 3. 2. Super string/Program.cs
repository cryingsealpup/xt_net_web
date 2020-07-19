using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordRussian = "Окошко";
            string wordEnglish = "windOw";
            string wordMixed = @"кd0\/\/";
            string wordNumber = "04508";
            Console.WriteLine("Language of {0}: {1}", wordRussian, wordRussian.CheckLanguage());
            Console.WriteLine("Language of {0}: {1}", wordEnglish, wordEnglish.CheckLanguage());
            Console.WriteLine("Language of {0}: {1}", wordMixed, wordMixed.CheckLanguage());
            Console.WriteLine("Language of {0}: {1}", wordNumber, wordNumber.CheckLanguage());
        }
    }
}
