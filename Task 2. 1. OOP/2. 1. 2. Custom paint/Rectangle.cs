using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    class Rectangle : FilledShape
    {
        protected double heigth;
        protected double width;

        public Rectangle(double heigth, double width)
        {
            this.heigth = heigth; this.width = width;
            Console.WriteLine("Фигура Прямоугольник создана!");
        }

        public override double Area
        {
            get
            {
                double s = heigth * width;
                return s;
            }
        }

        public override double Perimeter
        {
            get
            {
                double s;
                s = 2 * heigth + 2 * width;
                return s;
            }
        }

        public override void Print()
        {
            Console.WriteLine("\nФигура прямоугольник");
            Console.WriteLine("\tСтороны прямоугольника: a = {0}, b = {1}", width, heigth);
            Console.WriteLine("\tПериметр: p = {0:f3}" + Perimeter + "\tПлощадь: s = {0:f3}" + Area);
        }
    }
}
