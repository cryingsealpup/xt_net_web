using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Enemy : MovingObject
    {
        public static int damage;
        public Enemy(int x, int y, int userDamage) : base(x, y)
        {
            damage = Math.Abs(userDamage);
        }
        public void GetDamage(Player player)
        {
            player.health -= damage;
            Console.WriteLine("You attacked! Your health now: {0}", player.health);
        }

        public override void MakeMove()
        {
            var randomize = new Random();
            if (randomize.Next(0, 2) == 0)
            {
                if (this.CanMove(this.X - randomize.Next(-1, 2), this.Y))
                    this.X -= randomize.Next(-1, 2);
            }
            else
            {
                if (this.CanMove(this.X, this.Y - randomize.Next(-1, 2)))
                    this.Y -= randomize.Next(-1, 2);
            }
        }
    }
}