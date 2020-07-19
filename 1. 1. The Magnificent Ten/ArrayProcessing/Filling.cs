using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessing
{
    enum Colors
    {
        Blue, Green, Yellow, White, Red,
        Pink, Black, Orange, Brown, Gray
    }
    public class Filling
    {
        private static Random _Rnd = new Random();
        public static val GetRandomColor<val>() // array filling by enums
        {
            Array color = Enum.GetValues(typeof(val));
            return (val)color.GetValue(_Rnd.Next(color.Length));
        }

        public static int GetRandomNumber() // array filling by integers
        {
            return _Rnd.Next(1, 1000);
        }

        public static string[] BubbleSort(string[] array)
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

        public int[] SelectionSorting(int[] arr) // selection sort for integers array
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

        public static void InsertWithIntValues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = GetRandomNumber();
        }

        public static void InsertWithColors(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = GetRandomColor<Colors>().ToString();
        }
    }
}
