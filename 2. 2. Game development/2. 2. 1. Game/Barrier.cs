using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Barrier : Point
    {
        public Barrier(int x, int y) : base(x, y) {; }

        public void Avoid(Point point)
        {
            Console.WriteLine("You crashed into barrier!");
            var randomize = new Random();
            if (randomize.Next(0, 2) == 0) point.X -= 1; 
            else point.Y -= 1;
        }
    }
}
