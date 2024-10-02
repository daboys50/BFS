using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

//namespace AISearchSample
//{
//    class Fringe2:Fringes
//{
//        Stack<Node> s;
//       // Queue<Node> s;
//        public Fringe2() 
//        {
//            s = new Stack<Node>();
//           // s = new Queue<Node>();
//        }

//        public void add(Node n,Node origin)
//        {
//            n.Origin = origin;
//            s.Push(n);
//            //s.Enqueue(n);
//        }

//        public Node remove()
//        {
//            if (s.Count != 0)
//            //    return s.Dequeue();
//                 return s.Pop();
//            return null;
//        }
//    }
//}


namespace AISearchSample
{
    // Implement BFS Fringe
    class Fringe2 : Fringes
    {
        Queue<Node> queue; // Use a queue for BFS

        public Fringe2()
        {
            queue = new Queue<Node>(); // Initialize the queue
        }

        // Add a node to the queue
        public void add(Node n, Node origin)
        {
            n.Origin = origin; // Set the origin (previous node)
            queue.Enqueue(n); // Enqueue the node (FIFO)
        }

        // Remove a node from the queue
        public Node remove()
        {
            if (queue.Count != 0)
                return queue.Dequeue(); // Dequeue the next node in the queue
            return null;
        }
    }
}
