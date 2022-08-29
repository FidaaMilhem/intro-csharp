using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    public class SortedNumbersList : SortedNumbers
    {
        private List<int> _listnumber;
        private bool _ascending = true;
        public SortedNumbersList(bool ascending)
        {
            _listnumber = new List<int>();
            _ascending = ascending;
        }
        public bool Add(int x)
        {
            int befor = Count();
            var index = FindPlace(x);
            _listnumber.Insert(index, x);
            return Count() > befor;
        }

        //private bool Order(int x, int y)
        //{
        //    if (_ascending== false) return x < y;
        //    else return x > y;
        //}




        private int FindPlace(int x)
        {

            if (Count()==0)
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

            //if ((x > _listnumber[left]) && (_ascending = false))
            //{
            //    return left;
            //}
            //if ((x < _listnumber[right]) && (_ascending = false))
            //{
            //    return right + 1;
            //}

            

            //if (Order(x , _listnumber[right]))
            //{
            //    return right + 1;
            //}
            //if (Order(x , _listnumber[left]))
            //{
            //    return left;
            //}



            //if (Order(_listnumber[left] , x )) return left;
            //if (Order(_listnumber[right] , x)) return right +1 ;


            int mid = (left + right) / 2; ;
            while (left < right)
            {
                var element = Get(mid);
                if (x > element)
                {
                    left = mid+1;
                }
                else if(x < element)
                {
                    right = mid;
                }
                else
                {
                    return mid;
                }
                mid = (left + right) / 2;
            }

            return mid;

            //for (int i = 0; i < _listnumber.Count; i++)
            //{
            //    if (x <= _listnumber[i])
            //    {
            //        return i;
            //    }
            //}

            //return _listnumber.Count;

            //var index = 0;
            //while ((index < _listnumber.Count) && (_listnumber[index] < x))
            //{
            //    index++;
            //}

            //return index;
        }

        public int Count()
        {
            return _listnumber.Count();
        }

        public  int Get(int index)
        {
            int n = index;
            if (_ascending == false) n = Count() -1- index;
          
            return _listnumber[n];
        }

        public int Max()
        {
            return _listnumber.Max();
        }

        public int Min()
        {
            return _listnumber.Min();
        }

        public bool Remove(int x)
        {
            return _listnumber.Remove(x);
        }

        //public override int FindPlace(this int x)
        //{
        //    return Find.FindPlace(this);
        //}


    }
}
