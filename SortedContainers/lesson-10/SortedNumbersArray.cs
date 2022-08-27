using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    internal class SortedNumbersArray : SortedNumbers
    {

        private int[] _array;
        private int _count = 0;    
        public SortedNumbersArray(int capacity)
        {
            _array = new int[capacity];
        }

        //public bool Add(int x)
        //{            
        //    if (_count >= _array.Length)
        //    {
        //        return false;
        //    }

        //    int index = _count;
        //    while ((index > 0) && (_array[index - 1] > x))
        //    {
        //        _array[index] = _array[index - 1];
        //        index--;
        //    }

        //    _array[index] = x;
        //    _count++;

        //    return true;
        //}

        public bool Add(int x)
        {
            int befor = Count();
            var index = FindPlace(x);
            _array[index] = x;
            return Count() > befor;
        }
        private int FindPlace(int x)
        {
            if (Count() == 0)
            {
                return Count();
            }
            int left = 0;
            int right = Count() - 1;

            if (x < Get(left))
            {
                return left;
            }
            if (x > Get(right))
            {
                return right + 1;
            }

            while (left <= right)
            {
                int mid = (left + right) / 2;
                var element = Get(mid);
                if (x > element)
                {
                    left = mid + 1;
                }
                else if (x < element)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return Count();
        }

        public int Count()
        {
            return _count;
        }

        public int Get(int index)
        {
            return _array[index];
        }

        public int Max()
        {
            return _array[_count-1];
        }

        public int Min()
        {
            return _array[0];
        }

        public bool Remove(int x)
        {
            int loc = find(x);

            if (loc == -1)
            {
                return false;
            }

            shift(loc, 1);
            _count--;

            return true;

        }

        private void shift(int loc, int direction)
        {
            for (int j = loc; j < _count; j++)
            {
                _array[j] = _array[j + direction];
            }
        }

        private int find(int x)
        {
            for (int i = 0; i < _count; i++)
            {
                if (x == _array[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
