using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    class Circumference : Shape
    {
        public Point centre;
        public double radius;
        public Circumference(Point centre, double radius)
        {
            this.centre = centre;
            this.radius = radius;
        }

        public double CircumferenceOfCircle
        {
            get
            {
                double l = 2 * Math.PI * radius;
                return l;
            }
        }

        public override void Print()
        {
            Console.WriteLine("Фигура Окружность");
            Console.WriteLine("\tКоординаты центра: x = {0} \ty = {1} \tРадиус: r = {2}", centre.X, centre.Y, radius);
            Console.WriteLine("\t Длина окружности: l = " + CircumferenceOfCircle);
        }
    }
}
