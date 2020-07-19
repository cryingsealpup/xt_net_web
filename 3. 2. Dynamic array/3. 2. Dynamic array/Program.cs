using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 3, 4, 5, 6 };
            var array = new DynamicArray<int>(list);

            Console.WriteLine("Массив: ");
            array.Print();

            Console.WriteLine("Свойство Length : {0}", array.Length);
            Console.WriteLine("Свойство Capacity: {0}", array.Capacity);

            Console.WriteLine("Метод Add, добавляющий в конец массива один элемент (-9): ");
            array.Add(-9);
            array.Print();

            Console.WriteLine("Метод Remove, удаляющий из коллекции указанный элемент (12): ");
            array.Remove(12);
            array.Print();

            Console.WriteLine("Метод Insert, позволяющий добавить элемент в произвольную позицию массива (поз 3 элем 139): ");
            array.Insert(3, 2);
            array.Print();

            Console.WriteLine("Метод AddRange, добавляющий в конец массива содержимое коллекции, реализующей интерфейс IEnumerable<T>: ");
            array.AddRange(list);
            array.Print();

            Console.WriteLine("Индексатор — получить элемент на позиции 6: {0}", array[6]);
            Console.WriteLine("Отрицательная индексация — получить элемент на позиции -6: {0}", array[-1]);

            array.ChangeCapacity(2);
            Console.WriteLine("Ручное изменение capacity (2): ");
            array.Print();
        }

        
    }
}
