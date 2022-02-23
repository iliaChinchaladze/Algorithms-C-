using System;
using System.Collections.Generic;
using System.Text;

namespace week4Task2Portf
{
    class Book : IComparable

    {
        private string Title;
        private string ISBN;
        private string Author;

        public Book(string ISBN, string Title, String Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }

        public override string ToString()
        {
            return Title + " by " + Author + " ISBN: " + ISBN;
        }


        // Complete the code of CompareTo to compare two objects of the class Book

        public int CompareTo(Object other)
        {
            Book b = (Book)other;
            return b.Title.CompareTo(this.Title);
        }

    }
}
