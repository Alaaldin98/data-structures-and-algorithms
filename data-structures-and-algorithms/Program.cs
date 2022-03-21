using System;

namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the number representing the length of your array? ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now we need to fill your array");
            int[] array = new int[b];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Please enter the index {i + 1} of your array");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            reverseArray(array);
            Console.WriteLine();
            int[] arr = {3,4 ,7, 5};
            insertShiftArray(arr, 9);
        }
        static int[] insertShiftArray(int[] arr, int Numv)
        {
            int[] newArr = new int[arr.Length + 1];
            int set = Decimal.ToInt32(arr.Length / 2);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < set) newArr[i] = arr[i];
                else if (i == set) newArr[i] = Numv;
                else if (i >= set) newArr[i + 1] = arr[i];
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");

            }
            return newArr;
        }



        public static int reverseArray(int[] array)
        {
           
            Console.WriteLine("Your Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Your reverse Array is: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + "  ");
            }
            return array[0];
        }
        
    }
}
