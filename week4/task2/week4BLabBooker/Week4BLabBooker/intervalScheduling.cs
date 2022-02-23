using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4BLabBooker
{
    class intervalScheduling
    {
        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static void quickSortDD2(Request[] items, int left, int right)
        {
            int i, j;
            i = left; j = right;

            Request pivot = items[left];
           
            while (i <= j)
                {
                    //movemen of i 
                    for (; (items[i].CompareTo(pivot) < 0) && (i < right); i++) ;
                    // movement of j
                    for (; (pivot.CompareTo(items[j]) < 0) && (j > left)&&(j<= items.Length); j--) ;             
                    //swap if I>J
                    if (i <= j)
                        swap(ref items[i++], ref items[j--]);
                }        
            if (left < j)
                quickSortDD2(items, left, j);
            if (i < right)
                quickSortDD2(items, i, right);
        }

        public static string Maxevent(Request[] requests)
        {
            // sort array in increasing order of end time

            quickSortDD2(requests, 0, requests.Length - 1);
            string s = "Most efficient tasks to do";
            int k = 0;
            s += string.Format("ID{0} ", requests[0].ID);
            for (int i = 0; i < requests.Length; i++)
            {
                if(requests[i].Start >= requests[k].End)
                {
                    //found activity which has grater start time than last activitiy's finish time
                    s += string.Format("ID{0} ",  requests[i].ID);
                    k = i;
                }
            }
            return s;
            

        }

       
    }
}
