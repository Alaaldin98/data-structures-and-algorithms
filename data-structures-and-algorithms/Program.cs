
using System;
using data_structures_and_algorithms.HashTable;
using data_structures_and_algorithms.stack_queue_brackets;


namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
            Console.WriteLine("Hello World!");
            HashTables h = new HashTables(2);
            h.set("Alaa", 1000);
            h.set("Omar", 54);
            Console.Write(h.get("Alaa"));
            h.keys();


            //Console.WriteLine ( "Enter an expression:");
            //string expression = Convert.ToString(Console.ReadLine());
            //if (stack_Queue_Brackets.validatebrackets(expression))
            //    Console.WriteLine("Balanced\n");
            //else
            //    Console.WriteLine("Not Balanced\n");

        }


    }
}


