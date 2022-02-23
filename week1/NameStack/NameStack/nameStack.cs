using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameStack
{
    class nameStack
    {
        private const int maxsize = 10;
        public int top = 0;
        private Name[] array = new Name[maxsize];

        public void Push(Name value)
        {
            if (!IsFull())
            {
                array[top] = value;
                top++;
            }
        }
        public Name Pop()
        {
            if (!IsEmpty())
            {
                return array[--top] = null;
            }
            return null;
        }
        

        public bool IsFull()
        {
            return top == maxsize;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }
    }
}
