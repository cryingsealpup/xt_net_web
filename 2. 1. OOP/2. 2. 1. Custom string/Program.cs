using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlTypes;
using Custom_string;

namespace Custom_string_test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\t\tTESTS FOR CUSTOM STRING LIBRARY", ForegroundColor = ConsoleColor.Red);
            ResetColor();

            CustomString test = new CustomString("Hello world");
            CustomString testAsCharArray = new CustomString(new[] 
            { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' });
            int N = 5;

            WriteLine("\n\tCHECKING CONSTRUCTORS");
            WriteLine("\nString inputted as char array: " + testAsCharArray);
            WriteLine("String inputted as string type text: " + test);

            WriteLine("\n\tCHECKING OPERATOR OVERLOADINGS AND OVERRIDINGS");
            WriteLine("Is these CustomStrings equals? " + test.Equals(testAsCharArray));
            WriteLine("Multiplication with *: " + test * N);
            WriteLine("Sum with +: " + test + "!");
            WriteLine("Index [0]: " + test[0]);
            test[0] = 'Њ';
            WriteLine("Changing literal on index [0]: " + test);;

            WriteLine("\n\tCHECKING METHODS");
            WriteLine("\nIs 123 digit? " + CustomString.IsDigit(new CustomString("123")));
            WriteLine("Is Word digit? " + CustomString.IsDigit(new CustomString("Word")));
            WriteLine("Is 'e' literal in the string? " + test.Find('e'));

            WriteLine("\n\tOTHER");
            WriteLine("\nHow long this string? " + test.length + " symbols");
        }
    }
}
