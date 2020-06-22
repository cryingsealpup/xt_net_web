using System;

namespace Custom_paint
{
    class Line : Shape
    {
        public static Point a;
        public static Point b;

        public Line(Point from, Point to)
        {
            a = from; b = to;
            Console.WriteLine("\nФигура Отрезок создана!");
        }

        public double Length
        {
            get => Math.Sqrt(Math.Abs((a.X - b.X) * (a.X - b.X))
                + Math.Abs((a.Y - b.Y) * (a.Y - b.Y)));
        }

        public override void Print()
        {
            Console.WriteLine("Фигура Линия");
            Console.WriteLine("\tКоординаты начала и конца: ");
            Console.WriteLine("\tx1 = {0} \ty1 = {1}", a.X, a.Y);

            Console.WriteLine("\tx2 = {0} \ty2 = {1}", b.X, b.Y);
            Console.WriteLine("\tДлина линии: {0}", Length);
        }
    }
}
