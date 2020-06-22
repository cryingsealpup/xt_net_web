using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Fruit : Point
    {
        public static int bonus;
        public Fruit(int x, int y, int userBonus) : base(x, y) 
        {
            bonus = Math.Abs(userBonus);
        }
        public static void GiveBonus(Player player) => player.health += bonus;
    }
}
