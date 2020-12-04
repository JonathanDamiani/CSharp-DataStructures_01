using System;
namespace DataStructures_01
{
    // Queue node the inherent from node.
    // It is similiar to the LinkedList node, but as the two are different
    // Data structures, I have made then separated to easy undertanding.
    // The same is applyed to the stack node, the only difference is the name of.
    // The "Next" node
    public class QueueNode <T> : Node<T>
    {
        // Crete a next node to track the next of this.
        public QueueNode<T> next;

        // Contructor so set the data of this node and the next to null
        public QueueNode(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
