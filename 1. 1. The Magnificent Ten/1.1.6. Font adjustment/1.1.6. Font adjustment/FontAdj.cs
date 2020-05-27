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
        static string GetCurrentType(int c)
        {
            string[] arr = new string[8];

            for (int i = 0; i < 8; i++)
            {
                arr[i] = string.Format("{0, 3}", ((FontTypes)i).ToString());
            }

            return arr[c];
        }

        static void Main(string[] args)
        {
            List<int> curr = new List<int>();
            string[] names = Enum.GetNames(typeof(FontTypes));
            int state = -1;
            while (state != 0)
            {
                int sum = curr.ToArray().Sum();
                Console.WriteLine("Параметры надписи: {0}", GetCurrentType(sum));
                Console.WriteLine("Введите: ");
                for (int i = 1; i <= 3; i++)
                    Console.WriteLine("{0}: {1}", i, names[i]);
                Console.WriteLine("Или 0 для выхода");
                state = int.Parse(Console.ReadLine());
                if (state == 3) state ++;
                if (curr.Contains(state)) curr.Remove(state);
                else if (state <= 4 && state >= 0) curr.Add(state);
                else Console.WriteLine("Некорректный ввод");
            }

            Console.ReadKey();
        }
    }
}