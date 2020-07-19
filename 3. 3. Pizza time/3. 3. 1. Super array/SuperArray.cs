using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_array
{
    public static class SuperArray
    {
        public delegate float ProcessArray(float[] array);
        public static float MakeAction(this float[] array, ProcessArray action) => action.Invoke(array);

        public static float Sum(float[] array)
        {
            float sum = 0;
            foreach (float elem in array)
                sum += elem;
            return sum;
        }

        public static float Mode(float[] array)
        {
            var groups = array.GroupBy(v => v);
            float maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        public static float Average(float[] array) => (Sum(array)) / array.Length;
    }
}
