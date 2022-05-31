using System;
using data_structures_and_algorithms.stack_queue_brackets;
using data_structures_and_algorithms.QuickSort;

namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
            Console.WriteLine("Hello World!");
            
            Console.WriteLine ( "Enter an expression:");
            string expression = Convert.ToString(Console.ReadLine());
            if (stack_Queue_Brackets.validatebrackets(expression))
                Console.WriteLine("Balanced\n");
            else
                Console.WriteLine("Not Balanced\n");



            int[] arr = { 7, 11, 13, 5, 6, 7 };
            Quick_Sort quick_Sort = new Quick_Sort();
            quick_Sort.QuickSort(arr);

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }

    }
}


    