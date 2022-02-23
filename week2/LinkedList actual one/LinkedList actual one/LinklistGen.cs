using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_actual_one
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;
        public LinkListGen()
        {
            list = null;
        }



        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);

        }

        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkGen<T> newItem = new LinkGen<T>(item);
            // check to see if the item goes at the front of the list...
            if (temp == null || item.CompareTo(temp.Data) == -1)
            {
                list = new LinkGen<T>(item, list);
            }
            else
            {
                // you have to look at the next item and see if it's bigger
                //  which means it goes next.
                //  if there isn't a next item this item belongs next.
                // this item is bigger than the next item
                if (temp.Next == null ) 
                    {
                        
                        temp.Next = new LinkGen<T>(item, temp.Next);
                        temp = temp.Next;
                        
                        
                    }
                else if (temp.Next != null || item.CompareTo(temp.next.Data) ==-1)
                    {
                        temp = temp.Next;
                        newItem.next = temp.Next;
                        temp.Next = newItem;
                        
                }
               
                // move on to the next item
            }
        }
        
        public string DisplayList()
        {
            string output = "";
            LinkGen<T> temp = list; //start at beggining of list
            while(temp!=null)
            {
                output = output + "\r\n" + temp.Data.ToString();
                temp = temp.Next;// moves along one link
            }
            return output;
        }
        //serch for itemToFind and return a referance to it.


        public T Find (T itemsTofind)
        {
            LinkGen<T> temp = list;//start at beggining of list
            while (temp != null) //repeat until the end of list
            {
                if (itemsTofind.CompareTo(temp.Data)==0) //if itemToFind same as link.data
                {
                    return temp.Data;
                }
                temp = temp.Next; //move on a link
            }
            return default(T);//return an empty T if we did not find it
        }


        public T RemoveItem(T item)
        {
            LinkGen<T> temp = list;//start at beggining of list
            while (temp!= null)//repeat until the end of list
            {
                if (item.CompareTo(temp.Data) == 0)//if itemToFind same as link.data
                {
                    return temp.Data=default(T);
                }
                temp = temp.Next;//move on a link
            }
            return default(T);
        }

        


        //when add is pressed we display sorted list
        //in order to create sorted list we nedd a function 
        //what reads inputs from a list
        //finds lowes adds to another lists and removes from actual list
    }
}


