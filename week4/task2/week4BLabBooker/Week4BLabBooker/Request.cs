using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4BLabBooker
{
    class Request :IComparable
    {
        private int id;
        private float start;
        private float end;

        public Request(int id, float start, float end)
        {
            this.id = id;
            this.start = start;
            this.end = end; 
        }
        public Request()
        {
           
        } 

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public float Start
        {
            get { return start; }
            set { start = value; }
        }
        public float End
        {
            get { return end; }
            set { end = value; }
        }


        public override string ToString()
        {
            return "ID "+id + " Start: " + start + " End: " + end + Environment.NewLine;
        }

        public int CompareTo(Object obj)
        {
            Request other = (Request)obj;
            return End.CompareTo(other.End);
        }

    }
}
