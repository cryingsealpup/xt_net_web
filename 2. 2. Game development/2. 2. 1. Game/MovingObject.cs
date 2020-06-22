using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    abstract class MovingObject : Point
    {
        public MovingObject(int x, int y) : base(x, y) {; }
        abstract public void MakeMove();

        public bool CanMove(int newX, int newY)
        {
            int tempX = X + newX;
            int tempY = Y + newY;
            if (tempX >= Field.width || tempX < 0
                || tempY >= Field.heigth || tempY < 0) return false;

            X = tempX;
            Y = tempY;

            return true;
        }
    }
}
