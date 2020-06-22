using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    class CustomPaint
    {
        static List<Shape> shapesList = new List<Shape>();
        public static int GetIntValue()
        {
            var value = Console.ReadLine();
            int number = 0;
            if (!int.TryParse(value, out number))
            {
                Console.WriteLine("Некорректный ввод!");
                return GetIntValue();
            }
            else return number;
        }
        enum Shapes
        {
            Линия = 1, Окружность, Круг, Кольцо, Прямоугольник, Квадрат, Треугольник
        }

        public static int SelectInShapeMenu()
        {
            Console.WriteLine("Выберите тип фигуры: ");
            string[] names = Enum.GetNames(typeof(Shapes));
            for (int i = 1; i <= 7; i++)
                Console.WriteLine(i + ". " + names[i - 1]);
            int index = GetIntValue();
            if (index > 0 && index - 1 < names.Length) return index;
            else
            {
                Console.WriteLine("Неверный тип фигуры. Попробуйте ещё раз");
                return SelectInShapeMenu();
            }
        }

        public static int SelectInUserActionMenu()
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Вывести фигуры");
            Console.WriteLine("3. Очистить холст");
            Console.WriteLine("4. Выход");

            int index = GetIntValue();
            if (index > 0 && index < 5) return index;
            else
            {
                Console.WriteLine("Неверное действие. Попробуйте ещё раз");
                return SelectInUserActionMenu();
            }
        }

        public static void AddShape()
        {
            switch (SelectInShapeMenu())
            {
                default:
                    break;
                case 1:
                    shapesList.Add(ShapesMenu.MakeLine());
                    break;
                case 2:
                    shapesList.Add(ShapesMenu.MakeCircumference());
                    break;
                case 3:
                    shapesList.Add(ShapesMenu.MakeCircle());
                    break;
                case 4:
                    shapesList.Add(ShapesMenu.MakeRing());
                    break;
                case 5:
                    shapesList.Add(ShapesMenu.MakeRectangle());
                    break;
                case 6:
                    shapesList.Add(ShapesMenu.MakeSquare());
                    break;
                case 7:
                    shapesList.Add(ShapesMenu.MakeTriangle());
                    break;
            }
        }

        public static void PrintCurrent()
        {
            if (shapesList.Count == 0) Console.WriteLine("Фигур нет");
            foreach (Shape shape in shapesList)
            {
                shape.Print();
            }
        }
        public static void MakeAction(int index)
        {
            switch(index)
            {
                default:
                    break;
                case 1:
                    AddShape();
                    break;
                case 2:
                    PrintCurrent();
                    break;
                case 3:
                    shapesList.Clear();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void PrintMenu()
        {
            while(true) 
            {
                int index = SelectInUserActionMenu();
                MakeAction(index);
                Console.WriteLine();
            }
        }
    }
}
