using System;
namespace DataStructures_01
{
    // Stacked node the inherent from node.
    // It is similar to others but to easy understanding I have made then
    // Separated.
    public class StackNode <T> : Node<T>
    {
        // Crete a below node to track the "below" of the stack.
        public StackNode<T> below;

        // Contructor of the stack node.
        public StackNode(T data)
        {
            this.data = data;
            below = null;
        }
    }
}
