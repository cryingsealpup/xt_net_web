using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Field
    {
        public const int width = 9, heigth = 9;

        private char[,] field;

        public Field() => field = new char[width, heigth];

        public void BuildField(Player player, Fruit fruits, Enemy enemies, Barrier barriers)
        {
            field = new char[width, heigth];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < heigth; j++)
                {
                    if (i == fruits.X && j == fruits.Y) field[i, j] = '$';
                    else if (i == player.X && j == player.Y) field[i, j] = 'U';
                    else if (i == enemies.X && j == enemies.Y) field[i, j] = '@';
                    else if (i == barriers.X && j == barriers.Y) field[i, j] = 'T';
                    else field[i, j] = '.';
                }
        }

        public void PrintField()
        {
            Console.WriteLine();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++) 
                    Console.Write($"{field[i, j]} ");
                Console.WriteLine();
            }

        }
    }
}
