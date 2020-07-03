using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weakest_link
{
    class Human<T>
    {
        public T Value { get; set; }
        public Human<T> Next { get; set; }
        public Human<T> Previous { get; set; }
    }
}
