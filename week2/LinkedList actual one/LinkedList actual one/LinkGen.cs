using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_actual_one
{
    class LinkGen<T>
    {
        private T data;
        public LinkGen<T> next;
        public LinkGen(T item)
        {
            data = item;
            next = null;
        }
        public LinkGen(T item, LinkGen<T> list)
        {
            data = item;
            next = list;
        }

        
        public LinkGen<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public T Data
        {
            get { return data; }
            set { data = value;}
        }
    }

}
