using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class DynamicArray<T> : IEnumerable<T>, ICloneable
    {
        private int _length = 0;
        private int _capacity = 8;
        private T[] _array;

        public int Capacity
        {
            get => _capacity;
            protected set => _capacity = value;
        }
        public int Length
        {
            get => _length;
            protected set => _length = value;
        }

        public DynamicArray() => _array = new T[_capacity]; // конструктор без параметров
        public DynamicArray(int capacity) // указанная ёмкость
        {
            _capacity = capacity;
            _array = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> list) // принимающий  коллекцию
        {
            _array = new T[list.Count()];
            CopyToArray(list);
        }

        void CopyToArray(IEnumerable<T> collection, int index = 0) 
        {
            foreach (var item in collection)
            {
                _array[index] = item;
                index++;
                _length++;
            }
        }

        public object Clone()
        {
            T[] clone = new T[Capacity];
            clone = _array;
            return new DynamicArray<T>
            {
                Capacity = this.Capacity,
                Length = this.Length,
                _array = clone
            };
        }

        public void Add(T element) // добавить элемент в конец
        {
            if (AnyEmptyCell())
            {
                int emptyCellIndex = GetEmptyCellIndex();
                _array[emptyCellIndex] = element;
            }
            else
            {
                var expandedArray = new T[_array.Length + 1];
                for (int i = 0; i < _array.Length; i++)
                    expandedArray[i] = _array[i];
                _array = expandedArray;
                _array[_array.Length - 1] = element;
            }
        }
        public void AddRange(IEnumerable<T> collection)
        {
            int sumCount = _length + collection.Count();
            int multiplier = GetNewCapacity(_capacity, sumCount);
            Increase(multiplier);
            CopyToArray(collection, _length);
        }

        public bool Remove(T item)
        {
            int indexOfItem = IndexOf(item);
            if (indexOfItem < 0) return false;
            RemoveAt(indexOfItem);
            return true;
        }
        public void RemoveAt(int index)
        {
            if (_capacity > 0)
            {
                for (int i = index; i < _capacity - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _length -= 1;
            }
        }

        public void Insert(int index, T item)
        {
            CheckRange(index);

            if (_length == _capacity) Increase();

            for (int i = _length - 1; i > index; i--)
                _array[i] = _array[i - 1];

            _array[index] = item;
            _length++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _array)
            {
                yield return item;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => this.GetEnumerator();

        public int IndexOf(T item)
        {
            int index = 0;
            foreach (var element in _array)
            {
                if (element.Equals(item))
                    return index;
                index++;
            }
            return -1;
        }

        private void CheckRange(int index)
        {
            if (index < 0 || index >= _length)
                throw new ArgumentOutOfRangeException(); 

        }

        public T this[int index]
        {
            get
            {
              //  CheckRange(index);
                if (index < 0 && index >= (-_length)) index += _length - 1;
                return _array[index];
            }
            set
            {
            //    CheckRange(index);
                if (index < 0 && index >= (-_length)) index += _length;
                _array[index] = value;
            }
        }

        public T[] ToArray() => _array;

        private bool AnyEmptyCell()
        {
            for (int i = 0; i < _array.Length; i++)
                if (_array[i].Equals(default(T))) return true;
            return false;
        }

        private int GetEmptyCellIndex()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(default(T))) return i;
            }
            throw new Exception();
        }

        private int GetNewCapacity(int currentCapacity, int sumElementsCount)
        {
            int multiplier = 1;

            while (currentCapacity < sumElementsCount)
            {
                multiplier *= 2;
                currentCapacity *= multiplier;
            }

            return multiplier;
        }

        private void Increase(int multiplier = 2)
        {
            T[] temp = new T[_capacity *= multiplier];
            _array.CopyTo(temp, 0);
            _array = temp;
        }
        public void Print()
        {
            foreach (var elem in this)
                Console.Write($" {elem} ");
            Console.WriteLine(Environment.NewLine);
        }

        public void ChangeCapacity(int capacity)
        {
            T[] temp = new T[capacity];
            Array.Copy(_array, 0, temp, 0, capacity);
            _array = temp;
            Capacity = capacity;
            Length = _array.Length;
        }
    }
}

