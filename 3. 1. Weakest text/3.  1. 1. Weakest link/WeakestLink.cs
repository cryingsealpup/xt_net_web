using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weakest_link
{
    class WeakestLink
    {   
        public static int GetTheNumber()
        {
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value)) break;
                else
                    Console.WriteLine("Некорректный ввод! Попробуйте ещё раз");
            }
            return value;

        }
        public static void MakeAList()
        {
            Console.WriteLine("Введите N: ");
            int N = GetTheNumber();
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            int K = GetTheNumber();
            СrossOffTheList(N, K);
        }
        public static void СrossOffTheList(int circleSize, int steps = 1)
        {
            var circle = new People<int>();
            foreach (int i in Enumerable.Range(1, circleSize)) circle.Add(i);

            int counter = 0;
            while (circle.Count >= steps)
            {
                circle.Step(steps);
                circle.RemoveCurrent();
                Console.WriteLine($"Раунд {counter + 1}. Вычеркнут человек. Людей осталось: {circle.Count}");
                counter++;
            }

            Console.WriteLine($"Игра окончена. Невозможно вычеркнуть больше людей.");
        }
    }
}
