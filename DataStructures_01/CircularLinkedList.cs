﻿using System;
namespace DataStructures_01
{
    // Create Circular Single Linked List data structure. Every node keep track of itself
    // and the next one to it, we can get any node, and remove any node in every
    // index of the list, as well the next of the last node is the first node,
    // creating a circular list.
    public class CircularLinkedList <T>
    {
        public CircularLinkedList()
        {
        }

        // Head node to track the first node of the list
        protected LinkedListNode<T> head;

        // Tail node to track the last node of the list
        protected LinkedListNode<T> tail;

        // Appends entry to end of list.
        public virtual void Append(T entry)
        {
            // Creating node to be the new node.
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
                    // the next of the tail to be the head.
                    if (currentNode == tail)
                    {
                        currentNode.nextNode = newNode;
                        tail = newNode;
                        tail.nextNode = head;
                        break;
                    }
                    // Set the current node to be next node.
                    else
                    {
                        currentNode = currentNode.nextNode;
                    }
                }
            }
        }

        // Insert entry at supplied index, return true on success, false on error.
        public virtual bool Insert(T entry, int index)
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
                            // if head is null, make the new node the head and
                            // the tail to be equal the head.
                            if (head == null)
                            {
                                head = newNode;
                                tail = head;
                            }
                            // if head is not null make the new node the head
                            // then the next of the new node to point to the
                            // old head and make the next of the tail to be
                            // the new head.
                            else
                            {
                                newNode.nextNode = head;
                                head = newNode;
                                tail.nextNode = head;
                            }
                        }
                        // If the index is equal the size, it means that it try
                        // to insert after the tail, so make the new node the tail
                        // and uptade the the next of it.
                        else if (index == Size())
                        {
                            previousNode.nextNode = newNode;
                            newNode.nextNode = head;
                            tail = newNode;
                        }
                        // If the index is not 0
                        // Make the next of previous node be the new node
                        // then the newNode next be the current node
                        // inserting the new node between the previous and the
                        // current
                        else
                        {
                            newNode.nextNode = currentNode;
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
        public virtual bool Remove(int index)
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
                            // make the next of the head the new head and
                            // update the next of the tail
                            else
                            {
                                head = head.nextNode;
                                tail.nextNode = head;
                            }

                        }
                        // If ii try the remove to tail set the new tail to be
                        // the previuos of it and then update the next of the tail
                        // to be head.
                        else if (index == Size() - 1)
                        {
                            tail = previousNode;
                            tail.nextNode = head;
                            
                        }
                        // If it is not the head remove the other node.
                        // Making the next of the previous be the next of the
                        // current node.
                        else
                        {
                            previousNode.nextNode = currentNode.nextNode;
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

        // Set entry to list entry at supplied index
        public void Replace(T entry, int index)
        {
            int counter = 0;

            LinkedListNode<T> currentNode = head;

            // Check if head is null 
            if (head == null)
            {
                throw new Exception("The list is empty");
            }
            // Check if the index is out of range
            else if (index > Size() || index < 0)
            {
                throw new Exception("The index is out of range");
            }
            else
            {
                // Loot through the list until find the node to replace
                while (true)
                {
                    // if find it, change the value of the data
                    if (counter == index)
                    {
                        // if it is the head change the value of the head.
                        if (index == 0)
                        {
                            head.data = entry;
                        }
                        else
                        {
                            currentNode.data = entry;
                        }
                        break;
                    }
                    // If is not the node to replace, add 1 to the counter
                    // and change current node be the next of itself
                    else
                    {
                        counter++;
                        currentNode = currentNode.nextNode;
                    }
                }
            }
        }

        // Returns the data contained at the provided index
        public T Get(int index)
        {
            // Current node to track the position on the list
            LinkedListNode<T> currentNode = head;

            // Counter to track the index
            int counter = 0;

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
                // Loop through the list until find the value to return
                while (true)
                {
                    if (counter == index)
                    {
                        return currentNode.data;
                    }
                    // If is not the node to get, add 1 to the counter
                    // and change current node be the next of itself
                    else
                    {
                        currentNode = currentNode.nextNode;
                        counter++;
                    }
                }
            }
        }

        // Return index of first instance of supplied entry or -1 if not found.
        public int Find(T entry)
        {
            LinkedListNode<T> currentNode = head;

            // Counter to track the index of the list
            int counter = 0;

            // Make the next of the tail null, for stop the loop
            tail.nextNode = null;

            // While current node is not null
            while (currentNode != null)
            {
                // If the current node data is equal the data that the user is
                // looking for, return the counter as it index.
                if (currentNode.data.Equals(entry))
                {
                    return counter;
                }
                // Else add 1 to the counter, and move to the next node.
                else
                {
                    counter++;
                    currentNode = currentNode.nextNode;
                }
            }

            // Make the next of the tail the head, to close the list again.
            tail.nextNode = head;

            return -1;
        }

        // Return current size of list.
        public int Size()
        {
            // Variable to store the size
            int size = 0;

            // If head is null throw an exception
            if (head == null)
            {
                throw new Exception("The list is empty");
            }

            // Node to track the node on the list
            LinkedListNode<T> currentNode = head;

            // Make the next of the tail null, for stop the loop
            tail.nextNode = null;

            // While current node is not null, keep incrementing the size
            // until the list is finished.
            while (currentNode != null)
            {
                size++;
                currentNode = currentNode.nextNode;
            }

            // Make the next of the tail the head, to close the list again.
            tail.nextNode = head;

            // return the size
            return size;
        }
    }
}
