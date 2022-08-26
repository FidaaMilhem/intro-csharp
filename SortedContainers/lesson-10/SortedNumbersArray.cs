using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    internal class SortedNumbersArray : SortedNumbers
    {

        private int[] _array { get; set; }
        private int _lenght = 0;    
        public SortedNumbersArray()
        {
            _array = new int[100];
        }

        public bool Add(int x)
        {
            int index = 0;
            if (_lenght < _array.Length)
            {
                index = _lenght;
                while ((index > 0) && (_array[index - 1] > x))
                {
                    _array[index] = _array[index - 1]; ;
                    _lenght--;
                }
                _array[index] = x;
                _lenght++;
                return true;
            }
            else
            {
                return false;
            }
       
        }

        public int Count()
        {
            return _lenght;
        }

        public int Get(int index)
        {
            return _array[index];
        }

        public int Max()
        {
            return _array[_lenght-1];
        }

        public int Min()
        {
            return _array[0];
        }

        public bool Remove(int x)
        {
            bool r = false;
            int loc = -1;    
            for (int i = 0; i < _array.Length; i++)
            {
                if (x == _array[i])
                {
                    loc = i;
                    r = true;
                    break;
                }

            }
            if (loc != -1)
            {
                for (int j = loc  ; j < _lenght; j++)
                {
                    _array[j] = _array[j + 1];
                }
                _lenght--;
            }
            return r;
        
        }
    }
}
