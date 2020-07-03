using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Weakest_link
{
    class People<T> : IEnumerable<T>
    {
        private Human<T> First { get; set; }
        private Human<T> Last { get; set; }
        private Human<T> Current { get; set; }
        public int Count { get; private set; }

        public void Add(T value)
        {
            if (First == null)
            {
                First = new Human<T> { Value = value };
                Count++;
                First.Next = First;
                First.Previous = First;
                Last = First;
                Current = First;
                return;
            }

            Last.Next = new Human<T>
            {   Value = value,
                Next = First,
                Previous = Last };
            Count++;
            Last = Last.Next;
            First.Previous = Last;
        }

        public void Step() => Current = Current.Next;

        public void Step(int steps)
        {
            for (int i = 0; i < steps; i++) Step();
        }

        public void RemoveCurrent()
        {
            var nextHuman = Current.Next;
            var prevHuman = Current.Previous;

            prevHuman.Next = nextHuman;
            nextHuman.Previous = prevHuman;

            if (Current == First) First = nextHuman; 
            if (Current == Last) Last = prevHuman; 

            Current = nextHuman;
            Count--;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Human<T> Human = First;

            do
            {
                yield return Human.Value;
                Human = Human.Next;
            } while (Human != First);

        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}