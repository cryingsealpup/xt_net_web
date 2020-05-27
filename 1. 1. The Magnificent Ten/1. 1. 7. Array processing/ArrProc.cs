using System;

namespace Array_processing
{
    public enum Colors
    {
        Blue, Green, Yellow, White, Red,
        Pink, Black, Orange, Brown, Gray
    }
    class ArrProc
    {
        private static Random _Rnd = new Random();
        public static val GetRandomColors<val> ()
        {
            Array color = Enum.GetValues(typeof(val));
            return (val) color.GetValue(_Rnd.Next(color.Length));
        }


        static string[] Sorting(string[] array)
        {
            bool flag = true; // simple bubble sort
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        string buf = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buf;
                        flag = true;
                    }
                }
            }

            return array;
        }


        static void Main(string[] args)
        {
            Console.Write("Input lenght of an array: ");
            int N = int.Parse(Console.ReadLine());
            string[] arr = new string[N];

            Console.WriteLine("\nRandomly filled w {0} colors array: ", N);
            for (int i = 0; i < N; i++)
            {
                var value = GetRandomColors<Colors>();
                arr[i] = value.ToString();
                Console.Write(arr[i] + " ");
            }

            arr = Sorting(arr);

            Console.WriteLine("\n\nWhen sorted: ");
            foreach (string elem in arr) Console.Write(elem + " ");

            Console.WriteLine("\n\nmin = {0}, max = {1}", arr[0], arr[N - 1]);

            Console.ReadKey();
        }
    }
}
