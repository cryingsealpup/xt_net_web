using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    class Triangle : FilledShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            Console.WriteLine("Фигура Треугольник создана!");
             this.a = a; this.b = b; this.c = c;
        }

        public override double Area
        {
            get
            {
                double p, s;
                p = Perimeter/2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }

        public override double Perimeter
        {
            get
            {
                double p;
                p = a + b + c;
                return p;
            }
        }

        public override void Print()
        {
            Console.WriteLine("\nФигура треугольник");
            Console.WriteLine("\tСтороны треугольника: a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("\tПлощадь: s = {0:f3}", Area);
            Console.WriteLine("\tПериметр: p = {0:f3}", Perimeter);
        }
    }
}
