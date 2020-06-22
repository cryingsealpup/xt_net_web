using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    class Square : Rectangle
    {
        public double side;
        public Square(double side) : base(side, side)
        {
            this.side = side;
            Console.WriteLine("Фигура Квадрат создана!");
        }

        public override void Print()
        {
            Console.WriteLine("\nФигура Квадрат");
            Console.WriteLine("\tСторона квадрата: a = {0}", side);
            Console.WriteLine("\tПериметр: p = {0:f3}" + Perimeter + "\tПлощадь: s = {0:f3}" + Area);
        }
    }
}
