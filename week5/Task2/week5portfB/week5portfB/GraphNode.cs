using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5portfB
{
    class GraphNode<T>
    {
        private T id;

        private LinkedList<T> adjList;

        public GraphNode(T id)
        {
            this.id = id;

            adjList = new LinkedList<T>();

        }

        public T ID
        {
            set { id = value; }
            get { return id; }
        }

        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);
        }

        public void RemoveEdge(GraphNode<T> to)
        {
            adjList.Remove(to.ID);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }



    }
}
