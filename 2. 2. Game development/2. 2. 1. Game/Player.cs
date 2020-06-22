using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Player : MovingObject
    {
        public int health = 100;
        public Player(int x, int y) : base(x, y) {; }
        public override void MakeMove()
        {   
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (this.CanMove(this.X--, this.Y)) this.X--;
                    break;
                case ConsoleKey.DownArrow:
                    if (this.CanMove(this.X++, this.Y)) this.X++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (this.CanMove(this.Y--, this.Y)) this.Y--;
                    break;
                case ConsoleKey.RightArrow:
                    if (this.CanMove(this.Y++, this.Y)) this.Y++;
                    break;
            }
        }
    }
}
