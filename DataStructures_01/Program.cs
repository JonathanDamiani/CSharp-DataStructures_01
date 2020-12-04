using System;

namespace DataStructures_01
{
    class Program
    {
        static void Main(string[] args)
        {

            // ***** Tests for Stack *****
            //Stack<int> myStack = new Stack<int>();

            //try
            //{
            //    Console.WriteLine(myStack.Pop());

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //myStack.Push(2);
            //myStack.Push(3);
            //myStack.Push(4);
            //myStack.Push(5);


            //Console.WriteLine(myStack.Peek());
            //myStack.Pop();
            //Console.WriteLine(myStack.Peek());
            //Console.WriteLine(myStack.Size());



            // ***** Tests for Queue *****


            //Queue<int> myQueue = new Queue<int>();

            //try
            //{
            //    Console.WriteLine(myQueue.Dequeue());

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //myQueue.Enqueue(2);
            //myQueue.Enqueue(3);
            //myQueue.Enqueue(4);
            //myQueue.Enqueue(5);
            //myQueue.Enqueue(6);
            //myQueue.Enqueue(7);


            //Console.WriteLine("Size:" + myQueue.Size());


            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine("Size:" + myQueue.Size());
            //Console.WriteLine(myQueue.Dequeue());

            //try
            //{
            //    Console.WriteLine("Size:" + myQueue.Size());

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}



            // ***** Tests for Single linked List *****


            //SingleLinkedList<int> myLinkedList = new SingleLinkedList<int>();

            //myLinkedList.Append(32);
            //myLinkedList.Append(22);
            //myLinkedList.Append(31);
            //myLinkedList.Append(99);
            //myLinkedList.Append(77);

            //myLinkedList.Insert(83, 2);
            ////Console.WriteLine(myLinkedList.Insert(43, 1));
            //try
            //{
            //    //Console.WriteLine(myLinkedList.Remove(2));
            //    //Console.WriteLine(myLinkedList.Size());
            //    Console.WriteLine(myLinkedList.Get(1));
            //    myLinkedList.Replace(20, 1);
            //    Console.WriteLine(myLinkedList.Get(1));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //Console.WriteLine(myLinkedList.Find(22));


            // ***** Tests for Double linked List *****



            //DoubleLinkedList<int> myDoubleLinkedList = new DoubleLinkedList<int>();

            //myDoubleLinkedList.Append(32);
            //myDoubleLinkedList.Append(22);
            //myDoubleLinkedList.Append(31);
            //myDoubleLinkedList.Append(99);
            //myDoubleLinkedList.Append(77);

            //myDoubleLinkedList.Insert(83, 2);
            //Console.WriteLine(myDoubleLinkedList.Insert(43, 1));
            //try
            //{
            //    Console.WriteLine(myDoubleLinkedList.Remove(0));
            //    Console.WriteLine(myDoubleLinkedList.Size());
            //    Console.WriteLine(myDoubleLinkedList.Get(1));
            //    myDoubleLinkedList.Replace(20, 1);
            //    Console.WriteLine(myDoubleLinkedList.Get(1));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //Console.WriteLine(myDoubleLinkedList.Find(22));


            // ***** Tests for Circular Single linked List *****


            //CircularLinkedList<int> myCircularLinkedList = new CircularLinkedList<int>();

            //myCircularLinkedList.Append(10);
            //myCircularLinkedList.Append(20);
            //myCircularLinkedList.Append(30);
            //myCircularLinkedList.Append(40);
            //myCircularLinkedList.Append(50);

            //myCircularLinkedList.Insert(83, 2);
            //Console.WriteLine(myCircularLinkedList.Insert(43, 6));
            //try
            //{
            //    Console.WriteLine(myCircularLinkedList.Remove(6));
            //    Console.WriteLine(myCircularLinkedList.Size());
            //    Console.WriteLine(myCircularLinkedList.Get(2));
            //    myCircularLinkedList.Replace(22, 1);
            //    Console.WriteLine(myCircularLinkedList.Get(1));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine(myCircularLinkedList.Find(10));


            // ***** Tests for Circular Double linked List *****


            DoubleCircularLikedList<int> myDoubleCircularLinkedList = new DoubleCircularLikedList<int>();

            myDoubleCircularLinkedList.Append(10);
            myDoubleCircularLinkedList.Append(20);
            myDoubleCircularLinkedList.Append(30);
            myDoubleCircularLinkedList.Append(40);
            myDoubleCircularLinkedList.Append(50);

            myDoubleCircularLinkedList.Insert(83, 3);
            //Console.WriteLine(myDoubleCircularLinkedList.Insert(43, 1));
            try
            {
                Console.WriteLine(myDoubleCircularLinkedList.Remove(3));
                Console.WriteLine(myDoubleCircularLinkedList.Size());
                Console.WriteLine(myDoubleCircularLinkedList.Get(1));
                myDoubleCircularLinkedList.Replace(22, 1);
                Console.WriteLine(myDoubleCircularLinkedList.Get(1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(myDoubleCircularLinkedList.Find(22));
        }
    }
}
