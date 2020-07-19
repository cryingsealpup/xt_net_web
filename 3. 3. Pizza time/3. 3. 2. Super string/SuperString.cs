using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Super_string
{
    public enum Languages
    {
        None, Russian, English, Number, Mixed
    }

    public static class SuperString
    {
        public static Languages CheckLanguage(this string word)
        {
            if (Regex.IsMatch(word, @"\b[\d]+\b"))
                return Languages.Number;
            else if (Regex.IsMatch(word, @"\b[A-Za-z]+\b"))
                return Languages.English;
            else if (Regex.IsMatch(word, @"\b[а-яА-ЯёЁъЪ]+\b"))
                return Languages.Russian;
            else if (Regex.IsMatch(word, @"[a-zA-Z]|[а-яА-Я]|[0-9]"))
                return Languages.Mixed;
            else
            {
                Console.WriteLine("not defined");
                return Languages.None;
            }
        }
    }
}
