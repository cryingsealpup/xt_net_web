using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_paint
{
    abstract class FilledShape : Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        
    }
}
