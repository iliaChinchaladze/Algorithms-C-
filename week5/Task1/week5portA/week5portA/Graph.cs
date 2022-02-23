using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5portA
{
    class Graph<T> where T : IComparable
    {
        public LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }
        // is a graph empty?



        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }



        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }




        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;
        }




        //ID -- > Node with that ID
        public GraphNode<T> GetNodebyID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                    return n;
            }
            return null;
        }



        // check if node "to" is adjacent to node 'from'

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            //find node from

            //get adjlist of form

            //check if to is in adjlist

            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {   //found node from
                    return n.GetAdjList().Contains(to.ID);
                }
            }
            return false;
        }



        // create a direct edge between node with id from to node with id to
        // from --> to
        public void AddEdge(T from, T to)
        {
            // get the node from the graph with id = from
            // get the node from the graph with id =to

            // estabilish n1-->n2

            GraphNode<T> n1 = GetNodebyID(from);

            GraphNode<T> n2 = GetNodebyID(to);

            //n1-->n2
            if (n1 != null & n2 != null)
                n1.AddEdge(n2);


        }
        public int DisplayNum()
        {
            return nodes.Count;
        }


        public int NumEdgesGraph()
        {

            // to be completeint
            int sum = 0;


            foreach (GraphNode<T> n in nodes)
            {
                // hint: this loop allows to run over all the nodes present in the   graph.

                // to get the total number of edges in the graph: 
                // you need to count how many outgoing edges each node has and then return the sum obtained considering all nodes in the graph

                // how can you get the number of outgoing edges for each node ? (i.e.,     use the adjacency list of the node)
                if (n.GetAdjList().Count() > 0)
                {
                    sum++;
                }

            }
            return sum;

        }

    }

       
}
