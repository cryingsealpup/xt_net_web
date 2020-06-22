using System;

namespace Custom_paint
{   
    class Circle : FilledShape
    {
        private static double radius;
        private static Point point;
        private static Circumference circumference;
        public Circle(Point centre, double userRadius)
        {
            point = centre;
            radius = userRadius;
            circumference = new Circumference(point, radius);
        }
        public override double Area
        {
            get
            {
                double s = Perimeter * radius / 2;
                return s;
            }
        }

        public override double Perimeter
        {
            get => circumference.CircumferenceOfCircle;
        }

        public override void Print()
        {
            Console.WriteLine("Фигура Круг");
            Console.WriteLine("\tКоординаты центра: x = {0} \ty = {1} \tРадиус: r = {2}", point.X, point.Y, radius);
            Console.WriteLine("\tПериметр: p = " + Perimeter + "\tПлощадь: s = \t" + Area);
        }
    }
}
