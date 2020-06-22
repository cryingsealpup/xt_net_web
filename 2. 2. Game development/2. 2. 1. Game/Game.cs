using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Game
    {

        public static void Play()
        {
            var player = new Player(0, 3);
            var blueAnaconda = new Enemy(5, 2, 10);
            var scaryGorilla = new Enemy(5, 8, 10);
            var banana = new Fruit(3, 4, 1);
            var avocado = new Fruit(5, 4, 6);
            var march = new Barrier(6, 4);
            var fallenTree = new Barrier(8, 3);

            var field = new Field();
            Console.WriteLine("Play game until collecting  all bonuses or die! ");
            while (player.health > 0)
            {
                if (player.Equals(banana))
                {
                    Console.WriteLine("You got the fruit! ");
                    break;
                }
                field.BuildField(player, banana, blueAnaconda, march);
                field.PrintField();
                if (player.Equals(blueAnaconda)) blueAnaconda.GetDamage(player);
                if (player.Equals(march)) march.Avoid(player);
                if (blueAnaconda.Equals(march)) march.Avoid(blueAnaconda);
                player.MakeMove();
                blueAnaconda.MakeMove();
                
            }
            Console.WriteLine("You lose! ");

        }
    }
}
