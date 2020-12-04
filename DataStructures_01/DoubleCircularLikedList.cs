using System;
namespace DataStructures_01
{
    // Create Circular Double Linked List data structure. Every node keep track of itself,
    // the next one to it and also the previous one, we can get any node,
    // index of the list and remove any node in every, as well the next node of
    // the last one is equal the first, and the previous of the first is the last,
    // so the list is circular in both ways.
    public class DoubleCircularLikedList <T> : CircularLinkedList<T>
    {
        public DoubleCircularLikedList()
        {
        }

        // Appends entry to end of list.
        public override void Append(T entry)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(entry);

            // Check if head is null, if it is create a node with the entry value
            // as the head and the tail
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            // If not put the new node at the last node of the list
            else
            {
                // Current node to track each node on the list, starting on the
                // head
                LinkedListNode<T> currentNode = head;


                // Loop through the list change the current node value to its,
                // next value, until it becomes null so the list is ended.
                while (true)
                {
                    // When the current node is the tail, set it next node to the
                    // be a new node and the tail to be the new node then
                    // the next of the tail to be the head, as well the previous
                    // of the new node to be the old tail, and the previous of the
                    // head the new tail.
                    if (currentNode == tail)
                    {
                        currentNode.nextNode = newNode;
                        newNode.previousNode = tail;
                        tail = newNode;
                        tail.nextNode = head;
                        head.previousNode = tail;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.nextNode;
                    }
                }
            }
        }

        // Insert entry at supplied index, return true on success, false on error.
        public override bool Insert(T entry, int index)
        {
            // Creting the counter to track the index on the list.
            int counter = 0;

            // Creating nodes to keep track of the current node, and the previuos
            // node on the list.
            LinkedListNode<T> currentNode = head;
            LinkedListNode<T> previousNode = head;

            // new node to insert on the list
            LinkedListNode<T> newNode = new LinkedListNode<T>(entry);

            // Check if head is null and if the index is different of 0,
            // there no way to add a node if there is no head, unless you adding
            // it on the head
            if (head == null && index != 0)
            {
                return false;
            }
            // Check if the index is out of range.
            else if (index > Size() || index < 0)
            {
                return false;
            }
            // Adding the node to list
            else
            {
                // Loop until add and them break the loop.
                while (true)
                {
                    // If it find the index passed by the user 
                    if (counter == index)
                    {
                        // If the index is 0 add it to the head
                        if (index == 0)
                        {
                            // if head is null, make the new node the head
                            if (head == null)
                            {
                                head = newNode;
                                tail = head;
                            }
                            // if head is not null make the new node the head then
                            // the previous of the new to be the tail
                            // then the next of the new node to point to the
                            // old head, and the tail to point to the new head.
                            else
                            {
                                newNode.previousNode = tail;
                                newNode.nextNode = head;
                                head = newNode;
                                tail.nextNode = head;
                            }
                        }
                        // If the index is equal the size of the list, insert the
                        // new node to be the new tail and update the tail next
                        // to be the head, and the previous to be the old tail
                        // than update the previous of the head to the new tail.
                        else if (index == Size())
                        {
                            newNode.previousNode = tail;
                            newNode.nextNode = head;
                            tail = newNode;
                            head.previousNode = tail;
                        }
                        // If the index is not 0
                        // Make the next of previous node be the new node
                        // then the newNode next be the current node
                        // inserting the new node between the previous and the
                        // current
                        else
                        {
                            newNode.nextNode = currentNode;
                            newNode.previousNode = previousNode;
                            currentNode.previousNode = newNode;
                            previousNode.nextNode = newNode;
                        }

                        return true;
                    }
                    // If it not the index to insert yet, increase the counter
                    // make the previous one be the current one and the current
                    // be the next of itself. 
                    else
                    {
                        counter++;
                        previousNode = currentNode;
                        currentNode = currentNode.nextNode;
                    }
                }
            }
        }

        // Remove entry at supplied index, return true on success
        public override bool Remove(int index)
        {

            int counter = 0;

            LinkedListNode<T> currentNode = head;
            LinkedListNode<T> previousNode = head;

            // Check if head is null 
            if (head == null)
            {
                throw new Exception("The list is empty");
            }
            // Check if the index is out of range
            else if (index >= Size() || index < 0)
            {
                throw new Exception("The index is out of range");
            }
            else
            {
                // Loot through the list until find the node the remove
                while (true)
                {
                    // If the counter is equal the index, it is the node to
                    // remove
                    if (counter == index)
                    {
                        // If the index is equal a 0, remove the head
                        if (index == 0)
                        {
                            // If the next node of the head is null
                            // make the head null
                            if (head.nextNode == null)
                            {
                                head = null;
                                tail = null;
                            }
                            // If the next node of the head is not null
                            // make the next of the head the new head.
                            // Update the previous the head to be tail.
                            // Update the next of the tail to be the head.
                            else
                            {
                                head = head.nextNode;
                                head.previousNode = tail;
                                tail.nextNode = head;
                            }

                        }
                        // If it is trying to remove the tail
                        // Make the tail the previous node.
                        // Update the previous the head to be tail.
                        // Update the next of the tail to be the head.
                        else if (index == Size() - 1)
                        {
                            tail = previousNode;
                            tail.nextNode = head;
                            head.previousNode = tail;

                        }
                        // If it is not the head remove the other node.
                        // Making the next of the previous be the next of the
                        // current node.
                        else
                        {
                            previousNode.nextNode = currentNode.nextNode;
                            currentNode.nextNode.previousNode = previousNode;
                        }

                        return true;
                    }
                    // If is not the node to remove, add 1 to the counter
                    // and make the previous node the current one and the
                    // current node be the next of itself
                    else
                    {
                        counter++;
                        previousNode = currentNode;
                        currentNode = currentNode.nextNode;
                    }
                }
            }
        }
 
    }
}
