using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_development
{
    class Instance
    {
        public int x, y;
        public virtual char Object => '*';

        public Field Field { get; set; }
        private void Move(int xTo, int yTo)
        {

        }

    }
}
