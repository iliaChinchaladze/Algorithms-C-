using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_actual_one 
{
    class wordClass : IComparable
    {
        private string word;
        private int occurrences = 1;
        private string isbn;

        public wordClass(string word, string isbn)
        {
            this.word = word;
            this.isbn = isbn;
        }
        

        //properties
        public string Word
        {
            get { return word; }
            set { word = value;}
        }
        public int Occurrences
        {
            get { return occurrences; }
            set { occurrences = value;}
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public override string ToString()
        {
            return word + ":" + occurrences.ToString();
        }
        public int CompareTo(object other)
        {
            wordClass obj = (wordClass)other;
            return this.isbn.CompareTo(obj.isbn);
        }
    }
}
