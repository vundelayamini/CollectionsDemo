using System;
using System.Collections.Generic;

namespace CollectoinsDemo
{
    class Program
    {
        static void Main(string[] args)//Main Method
        {
            Console.WriteLine("Welcome message to Collections demo");//Welcome message
             doStackDemo();
             doDictionaryDemo();
             doQueueDemo();
             doSetDemo();
            Console.ReadKey();
        }


        public static void doSetDemo()// create Set demo
        {
            var set = new HashSet<string>();
            set.Add("Ravi");//Add method
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doQueueDemo()// create a Queue Demo
        {
            //Creating a Queue
            Queue<string> queue = new Queue<string>();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("JaiShankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nInteracting the queue elements: ");
            //Iterating Queue elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element: " + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeu one element:");
            //Iterating Queue elements using enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


        }

        private static void doDictionaryDemo()// create a Dictionay Demo
        {
            Console.WriteLine("\nIn doStackDemo");
            //create a dictionary elements
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //Adding a key/value using add method
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("\nInnteracting Dictionary:");
            //Iterating dictionary elements
            foreach (var element in dictionary)
            {
                Console.WriteLine("key=" + element.Key + "& value=" + element.Value);
            }
        }
        private static void doStackDemo()//Create a stack demo
        {
            Console.WriteLine("\nIn doStckDemo");
            //Creating Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("yamini");
            stack.Push("mahi");
            stack.Push("Amit");
            stack.Push("marina");
            string pop = stack.Pop();
            //Iterating Stack elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped element: " + pop);
        }
        private static void doListDemo()//create a list 
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating  List
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            //Iterating List elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }


    }
}

