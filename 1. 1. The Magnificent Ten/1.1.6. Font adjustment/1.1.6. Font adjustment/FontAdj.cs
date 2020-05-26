using System;
using System.Collections.Generic;
using System.Linq;

namespace Font_adjustment
{
    [Flags]
    public enum FontTypes
    {   
        None = 0,
        bold = 1,
        italic = 2,
        underline = 4

    }

    class FontAdj
    {
        static string GetCurrType(int c)
        {
            var CurrType = FontTypes.None;
            switch (c) 
            {
                case 0:
                    break;
                case 1:
                    CurrType = FontTypes.bold;
                    break;
                case 2:
                    CurrType = FontTypes.italic;
                    break;
                case 3:
                    CurrType = FontTypes.bold | FontTypes.italic;
                    break;
                case 4:
                    CurrType = FontTypes.underline;
                    break;
                case 5:
                    CurrType = FontTypes.bold | FontTypes.underline;
                    break;
                case 6:
                    CurrType = FontTypes.italic | FontTypes.underline;
                    break;
                case 7:
                    CurrType = FontTypes.bold | FontTypes.italic | FontTypes.underline;
                    break;

            }
            return CurrType.ToString();
        }

        static void Main(string[] args)
        {
            List<int> curr = new List<int>();
            int state = -1;
            while (state != 0)
            {
                int sum = curr.ToArray().Sum();
                Console.WriteLine("Параметры надписи: {0}", GetCurrType(sum));
                Console.WriteLine("Введите: ");

                for (int i = 1; i <= 4; i++)
                {
                    if (i != 3) Console.WriteLine("{0,3}: {1}", i, ((FontTypes)i).ToString());
                }
                Console.WriteLine("Или 0 для выхода");
                state = int.Parse(Console.ReadLine());
                if (curr.Contains(state)) curr.Remove(state);
                else if (state <= 4 && state >= 0 && state != 3) curr.Add(state);
                else Console.WriteLine("Некорректный ввод");
            }

            Console.ReadKey();
        }
    }
}