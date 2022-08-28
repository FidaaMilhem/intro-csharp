using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    public interface SortedNumbers
    {
        int Max();
        int Min();
        int Count();
        bool Add(int x);  // bool 
        bool Remove(int x); // bool
        int Get(int index);
        //int sn[int x];
       // int Findplace(int x );
    }
}
