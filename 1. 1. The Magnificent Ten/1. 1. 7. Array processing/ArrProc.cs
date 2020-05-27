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
        public static val GetRandomColors<val> () // array filling by enums
        {
            Array color = Enum.GetValues(typeof(val));
            return (val) color.GetValue(_Rnd.Next(color.Length));
        }

        public static int GetRandomNumber() // array filling by integers
        {
            return _Rnd.Next(1, 1000);
        }

        static string[] BubbleSort(string[] array)
        {
            bool flag = true; // simple bubble sort for colors array
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

        static int[] SelectionSorting(int[] arr) // selection sort for integers array
        {
            int N = arr.Length;

            for (int i = 0; i < N - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                    if (arr[j] < arr[min])
                        min = j;
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        static void Main(string[] args)
        {
            Console.Write("Input lenght of an array: ");
            int N = int.Parse(Console.ReadLine());
            string[] ColArr = new string[N];
            int[] IntArr = new int[N];
            Console.Write("Choose type of an array (1 for colors filling, 2 for integers filling): ");
            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                Console.WriteLine("\nRandomly filled w {0} colors array: ", N);
                for (int i = 0; i < N; i++)
                {
                    var value = GetRandomColors<Colors>();
                    ColArr[i] = value.ToString();
                    Console.Write(ColArr[i] + " ");
                }

                ColArr = BubbleSort(ColArr);

                Console.WriteLine("\n\nWhen sorted: ");
                foreach (string elem in ColArr) Console.Write(elem + " ");

                Console.WriteLine("\n\nmin = {0}, max = {1}", ColArr[0], ColArr[N - 1]);
            }

            else if (type == 2)
            {
                Console.WriteLine("\nRandomly filled w {0} integers array: ", N);
                for (int i = 0; i < N; i++)
                {
                    int value = GetRandomNumber();
                    IntArr[i] = value;
                    Console.Write(IntArr[i] + " ");
                }

                IntArr = SelectionSorting(IntArr);

                Console.WriteLine("\n\nWhen sorted: ");
                foreach (int elem in IntArr) Console.Write(elem + " ");

                Console.WriteLine("\n\nmin = {0}, max = {1}", IntArr[0], IntArr[N - 1]);
            }

            else Console.WriteLine("Incorrect input");
            Console.ReadKey();
        }
    }
}
