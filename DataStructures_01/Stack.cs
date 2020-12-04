using System;

namespace DataStructures_01
{
    // Stack data structure. Works as a stack, the last in is the first out.
    // We have acess only to the top data.
    class Stack<T>
    {
        // Node that represent the top data
        StackNode<T> top;

        // Constructor
        public Stack() {}

        // Adds an entry to the top of the stack
        public void Push(T entry)
        {
            // If it is empty set the top data to be the new node.
            if (IsEmpty())
            {
                top = new StackNode<T>(entry);
            }
            // If it is not empty create a new node than set the below of it the
            // top node and then set the new node as the new top.
            else
            {
                StackNode<T> newNode = new StackNode<T>(entry);
                newNode.below = top;
                top = newNode;
             }
        }

        // Remove and returns the element at the top of the stack
        public T Pop()
        {
            // If the stack is empty throw an exception.
            if (IsEmpty())
            {
                throw new Exception("Is empty");
            }
            // If it is not empty, returt the data of the top, and set the top
            // to be the below of itself, removing the older top.
            else
            {
                T data = top.data;
                top = top.below;
                return data;

            }
        }   

        // Returns the element at the top of the Stack without removing it
        public T Peek()
        {
            // If the stack is empty throw an exception. 
            if (IsEmpty())
            {
                throw new Exception("Is empty");
            }
            // Just return the data of the top.
            else
            {
                return top.data;
            }
        }

        // // Return current size of stack.
        public int Size()
        {
            // Counter to count how many node is there on the stack
            int counter = 0;

            // Create a current node and set it as the same as the top
            StackNode<T> currentNode = top;

            // If the stack is empty throw an exception. 
            if (IsEmpty())
            {
                throw new Exception("Is empty");
            }
            // If it is not empty
            else
            {
                // Loop through the stack until the current node is null
                while (currentNode != null) 
                {
                    // increase the counter each time
                    counter++;
                    // set the current node to the below of it.
                    currentNode = currentNode.below;
                }

                // return the counter as the size of the list.
                return counter;
            }
        }

        //Returns true if there's nothing in the stack
        public bool IsEmpty()
        {
            // If the top is null so the list is empty, return true
            if (top == null)
            {
                return true;
            }
            // if is not null just return false as the stack is not empty
            else
            {
                return false;
            }
        }
    }
}
