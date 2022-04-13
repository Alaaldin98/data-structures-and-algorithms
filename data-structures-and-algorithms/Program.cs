using System;

namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.push(10);
            s.push(16);
            s.push(100);
            s.printStack();
            Console.WriteLine(s.pop());
            s.printStack();

            Queue q = new Queue();
            q.enqueue(10);
            q.enqueue(7);
            q.enqueue(26);
            q.printQueue();
            Console.WriteLine(q.dequeue());
            q.printQueue();

            Console.WriteLine("Hello World!");

            CodeChallenges codeChallenges = new CodeChallenges();



            int[] array1 = { 4, 10, 15, 26, 38, 65 };
            int key = 26;
            Console.WriteLine($"BinarySearch   { (array1, key)}");
            LinkedList linkedList = new LinkedList(8);
            linkedList.Append(key);

        }
    }
}


    