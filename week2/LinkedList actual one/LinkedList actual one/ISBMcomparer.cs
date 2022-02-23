using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_actual_one 
{
    class ISBMcomparer : IComparer<wordClass>
    {
        public int Compare(wordClass x, wordClass y)
        {
            if (object.ReferenceEquals(x, y))
                return 0;
            if (x == null)
                return -1;

            if (y == null)
                return 1;

            return x.ISBN.CompareTo(y.ISBN);
        }
    }
}
