using System;

namespace data_structures_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {3,4 ,7, 5};
            insertShiftArray(arr, 9);
        }
        static int[] insertShiftArray(int[] arr,int Numv)
        {
            int[] newArr = new int[arr.Length +1];
            int set = Decimal.ToInt32(arr.Length/2);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < set) newArr[i] = arr[i];
                else  if(i==set) newArr[i] = Numv;
                else if(i>=set) newArr[i+1] = arr[i];
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
              
            }
            return newArr;



        }
    }
}
