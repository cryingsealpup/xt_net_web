using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    class ShapesMenu
    {
        public static double DoubleValue()
        {
            var value = Console.ReadLine();
            double number = 0;
            if (!double.TryParse(value, out number))
            {
                Console.WriteLine("Некорректный ввод!");
                return DoubleValue();
            }
            else return number;
        }

        public static bool CheckPositivity(double value)
        {
            if (value > 0) return true;
            else return false;
        }
        public static Point MakePoint()
        {
            Console.Write("\tx = ");
            var x = DoubleValue();
            Console.Write("\ty = ");
            var y = DoubleValue();
            return new Point(x, y);
        }

        //1
        public static Circle MakeCircle()
        {
            Console.WriteLine("Введите координаты центра: ");
            var point = MakePoint();
            Console.WriteLine("Введите радиус: ");
            var r = DoubleValue();
            if (CheckPositivity(r))
            {
                Console.WriteLine("Фигура Круг создана! \n");
                return new Circle(point, r);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
                return MakeCircle();
            }
        }
        //2
        public static Circumference MakeCircumference()
        {
            Console.WriteLine("Введите координаты центра: ");
            var point = MakePoint();
            Console.WriteLine("Введите радиус: ");
            var r = DoubleValue();
            if (CheckPositivity(r))
            {
                Console.WriteLine("Фигура Окружность создана!\n");
                return new Circumference(point, r);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
                return MakeCircumference();
            }
        }
        //3
        public static Triangle MakeTriangle()
        {
            Console.WriteLine("Введите длины сторон: ");
            Console.Write("\ta = ");
            var a = DoubleValue();
            Console.Write("\tb = ");
            var b = DoubleValue();
            Console.Write("\tc = ");
            var c = DoubleValue();
            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                Console.WriteLine("Фигура Треугольник создана! ");
                return new Triangle(a, b, c);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
                return MakeTriangle();
            }
        }
        //4
        public static Ring MakeRing()
        {
            Console.WriteLine("Введите координаты центра: ");
            var point = MakePoint();
            Console.WriteLine("Введите длину радиуса внутренней окружности: ");
            Console.Write("r = ");
            var r = DoubleValue();
            Console.WriteLine("Введите длину радиуса внешней окружности: ");
            Console.Write("R = ");
            var R = DoubleValue();
            if (CheckPositivity(r) && CheckPositivity(R)) return new Ring(point, r, R);
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
                return MakeRing();
            }
        }
        //5
        public static Rectangle MakeRectangle()
        {
            Console.WriteLine("Введите значения ширины и высоты: ");
            Console.Write("a = ");
            var a = DoubleValue();
            Console.Write("b = ");
            var b = DoubleValue();
            if (CheckPositivity(a) && CheckPositivity(b)) return new Rectangle(a, b);
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
                return MakeRectangle();
            }
        }
        //6
        public static Square MakeSquare()
        {
            Console.WriteLine("Введите длину стороны: ");
            Console.Write("\ta = ");
            var a = DoubleValue();
            if (CheckPositivity(a)) return new Square(a);
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
                return MakeSquare();
            }
        }
        //7
        public static Line MakeLine()
        {
            Console.WriteLine("Введите координаты начала и конца отрезка: ");
            var a = MakePoint();
            var b = MakePoint();
            return new Line(a, b);
        }
    }
}
