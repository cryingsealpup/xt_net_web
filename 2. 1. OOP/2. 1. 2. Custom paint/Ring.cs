using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{   
    class Ring : FilledShape
    {
        private static Point point;
        private static double innerRadius, outerRadius;

        private Circle innerCircle; 
        private double innerCirclePerimeter; private double innerCircleArea;
        private Circle outerCircle; 
        private double outerCirclePerimeter; private double outerCircleArea;

        public Ring(Point center, double userInnerRadius, double userOuterRadius)
        {
            point = center;
            Console.WriteLine("Фигура Кольцо создана! ");
            innerRadius = userInnerRadius;
            outerRadius = userOuterRadius;
            outerCircle = new Circle(point, userOuterRadius);
            outerCirclePerimeter = outerCircle.Perimeter;
            outerCircleArea = outerCircle.Area;
            innerCircle = new Circle(point, userInnerRadius);
            innerCirclePerimeter = innerCircle.Perimeter;
            innerCircleArea = innerCircle.Area;
        }
        public override double Perimeter
        {
            get => innerCirclePerimeter + outerCirclePerimeter;
        }

        public override double Area
        {
            get => outerCircleArea - innerCircleArea;
        }

        public override void Print()
        {
            Console.WriteLine("Фигура Окружность");
            Console.WriteLine("\tКоординаты центра: x = {0} y = {1} \tВнутренний радиус: r = {2}" +
                " \tВнешний радиус: R = {3}", point.X, point.Y, innerRadius, outerRadius);
            Console.WriteLine("\tПериметр: p = " + Perimeter + "\tПлощадь: s = \t" + Area);
        }
    }
}
