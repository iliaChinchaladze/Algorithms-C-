using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameStack
{
    class Name : IComparable
    {
        private string fullName;

        public Name(string name)
        {
            this.fullName = name;
        }

        public string Fullname
        {
            set { this.fullName = value;}
            get { return this.fullName; }
        }

        public int CompareTo(object obj)
        {
            Name other = (Name)obj;
            return fullName.CompareTo(other.fullName);
        }
    }
}
