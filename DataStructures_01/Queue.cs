using System;
namespace DataStructures_01
{
    // Create queue data structure. First node in, first node out, works like a
    // line, you can track the front and the rear node. 
    public class Queue <T>
    {
        QueueNode<T> frontNode; // Front node
        QueueNode<T> rearNode; // Rear node

        // Contructor setting the nodes to null.
        public Queue()
        {
            frontNode = null;
            rearNode = null;
        }

        // Adds an entry to the rear of the queue
        public void Enqueue(T entry)
        {
            // Create a temporary node, that represent the new node.
            QueueNode<T> newNode = new QueueNode<T>(entry); 

            // Call the method IsEmpty() to check if the list is empty, if it
            // is empty, add set the front and the rear of the queue as the same
            // node.
            if (IsEmpty())
            {
                frontNode = newNode;
                rearNode = newNode;
            }
            // If it is not empty, so set the next of the rear to be the new node
            // then set the new node as the rear. 
            else
            {
                rearNode.next = newNode;
                rearNode = newNode;
            }
        }
        // Remove and returns the element at the front of the queue
        public T Dequeue()
        {
            // If the queue is empty throw an expeption.
            if (IsEmpty())
            {
                throw new Exception("Is empty");
            }
            // if the next of the front is null, so the queue has only one node,
            // in this case return the data of this node, and the make front and
            // the rear node null and the queue will be empty.
            else if(frontNode.next == null)
            {
                T data = frontNode.data;
                frontNode = null;
                rearNode = null;
                return data;
            }
            // If there are more than 1 node in the queue, the next of the front
            // will become the new front, and return the data of the old front.
            else
            {
                T data = frontNode.data;
                frontNode = frontNode.next;
                return data;
            }
        }

        // Return current size of queue.
        public int Size()
        { 
            // Create a counter to count all many nodes there is on the list
            int counter = 0;

            // Check if it is empty, and if it is, throw an exception
            if (IsEmpty())
            {
                throw new Exception("Is empty");
            }
            // If it is not empty loop through the queue incresing the counter.
            else
            {
                // Creating a node to represent the current node on the loop.
                QueueNode<T> currentNode = frontNode;
                // Loop until the current node is not null
                while (currentNode != null)
                {
                    counter++;
                    // Setting the current to be next node.
                    currentNode = currentNode.next;
                }

                // Returning the countes as the size of the queue
                return counter;
            }
        }   

        //Returns true if there's nothing in the queue
        public bool IsEmpty()
        {
            // If there is nothing on the rear it means that the queue is empty,
            // it could be done with the front as well.
            if (rearNode == null)
            {
                return true;
            }
            // If the rear is not null the queue is not empty.
            else
            {
                return false;
            }
        }
    }
}
