using System;

namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("input the length of your array");
           int a = Convert.ToInt32(Console.ReadLine());
            int[] arr =new int[a] ;
            Console.WriteLine("input the the number to fill your array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("input the number to insert and shift to your array");
            int b = Convert.ToInt32(Console.ReadLine());
            insertShiftArray(arr, b);
        }
        static int[] insertShiftArray(int[] arr,int Numv)
        {
            int[] newArr = new int[arr.Length +1];
            int conv = Decimal.ToInt32(arr.Length/2);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < conv) newArr[i] = arr[i];
                if(i==conv) newArr[i] = Numv;
                if(i>=conv) newArr[i+1] = arr[i];
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
              
            }
            return newArr;



        }
    }
}
