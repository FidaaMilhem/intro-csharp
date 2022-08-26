using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    public class SortedNumbersList : SortedNumbers
    {
        private List<int> _listnumber { get; set; }
        public SortedNumbersList()
        {
            _listnumber = new List<int>();    
        }
        public bool Add(int x)
        {
            int index = 0;
            while ((index < _listnumber.Count) && (_listnumber[index] < x))
            {
                index++;
            }
                    
            _listnumber.Insert(index,x);
            return true;
            
        }

        public int Count()
        {
            return _listnumber.Count();
        }

        public  int Get(int index)
        {
            return _listnumber[index];
        }

        public int Max()
        {
            return _listnumber.Max();
        }

        public int Min()
        {
            return _listnumber.Min();
        }

        public bool  Remove(int x)
        {
            int index=0;    
            _listnumber.Remove(x);
            return index > _listnumber.Count;
        }
    }
}
