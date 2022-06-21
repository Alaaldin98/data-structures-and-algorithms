
using System;
using data_structures_and_algorithms.HashTable;
using data_structures_and_algorithms.HashTable.Hashmap;
using data_structures_and_algorithms.stack_queue_brackets;


namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
            //Console.WriteLine("Hello World!");
            //HashTables h = new HashTables(2);
            //h.set("Alaa", 1000);
            //h.set("Omar", 54);
            //Console.Write(h.get("Alaa"));
            //h.keys();
            //hashmap_repeated_word hash = new hashmap_repeated_word();
            //Console.WriteLine("Enter the word!..");
            //string Word = Console.ReadLine();   // Read the Input string from User at Run Time  
            //hash.HashmapRepeatedWord(Word);

            //Console.WriteLine ( "Enter an expression:");
            //string expression = Convert.ToString(Console.ReadLine());
            //if (stack_Queue_Brackets.validatebrackets(expression))
            //    Console.WriteLine("Balanced\n");
            //else
            //    Console.WriteLine("Not Balanced\n");
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            //list.insertLast(5);
            list.Append(1);
            list.InsertBefore(60,2);
            list.Append(7);
            list.Append(8);
            list.Append(50);
                list.print();

            list.ReverseList(list);
            Console.WriteLine("***************");
            list.print();
            Console.WriteLine("***************");
            Console.WriteLine("***************");
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(2);
            list1.Append(3);
            list1.Append(4);
            list1.Append(5);
            list1.Append(6);
            Console.WriteLine("***************");
            LinkedList linkedList = new LinkedList();
            linkedList.ZipLists(list, list1);
            linkedList.print();
        }


    }
}


