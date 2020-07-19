using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Text_analysis
{
    class Analyser
    {
        private static string ReadFile(string text, string path)
        {

            try
            {
                foreach (string line in File.ReadLines(path, Encoding.UTF8))
                {
                    text += line;
                }
            }
            catch
            {
                Console.WriteLine("Incorect path! Try again");
            }
            return text;
        }

        private static string GetText()
        {
            Console.Write("Press W to input path to your text or press E to see work with test example ");
            string key = Console.ReadLine();
            string text = "";
            switch (key.ToLower())
            {
                case "w":
                    Console.WriteLine("Type path to your text here: \n");
                    string path = Console.ReadLine();
                    text = ReadFile(text, path);
                    break;
                case "e":
                    text = ReadFile(text, @"../../test.txt");
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    break;
            }

            return text;
        }
        public static void AnalyseText()
        {
            string text = GetText();
            Dictionary<string, int> stats = new Dictionary<string, int>();
            text = Regex.Replace(text, @"[^\w\d\s]", "");
            text = text.Replace("\n", "");
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (!stats.ContainsKey(word.ToLower())) stats.Add(word.ToLower(), 1);
                else stats[word.ToLower()] += 1;
            }
            Console.WriteLine("\t_____________________________________\n");
            var orderedStats = stats.OrderByDescending(x => x.Value);
            Console.WriteLine("\t\tTotal word count: {0}\n", stats.Count);
            bool flag = false;
            foreach (var pair in orderedStats) {
                Console.WriteLine("\tTotal occurrences of “{0}”: {1}", pair.Key, pair.Value);
                if (pair.Value / stats.Count * 100 > 40) flag = true;
            }
            if (flag == false) Console.WriteLine("\nEverything is okay!");
            else Console.WriteLine("\nThere's some problems...");
        }
    }
}
