﻿using System;

namespace data_structures_and_algorithms
{
<<<<<<< Updated upstream
    internal class Program
=======

    public class LinkedList
>>>>>>> Stashed changes
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            /*     Console.WriteLine("input the length of your array");
                int a = Convert.ToInt32(Console.ReadLine());
                 int[] arr =new int[a] ;
                 Console.WriteLine("input the the number to fill your array");

                 for (int i = 0; i < arr.Length; i++)
                 {
                     arr[i] = Convert.ToInt32(Console.ReadLine());
                 }

                 Console.WriteLine("input the number to insert and shift to your array");
                 int b = Convert.ToInt32(Console.ReadLine());


                 Console.WriteLine("Now we need to fill your array");
                 int[] array = new int[b];
                 for (int i = 0; i < array.Length; i++)
                 {
                     Console.WriteLine($"Please enter the index {i + 1} of your array");
                     array[i] = Convert.ToInt32(Console.ReadLine());
                 }
                 reverseArray(array);

                 insertShiftArray(arr, b); */

            int[] array = { 4, 10, 15, 26, 38, 65};
            int key = 26;
          if(  BinarySearch(array,0,array.Length, key) != -1)
            {
                Console.WriteLine(BinarySearch(array, 0, array.Length, key));
            }
          else 
                Console.WriteLine(-1);

        }
        static int[] insertShiftArray(int[] arr, int Numv)
        {

            int[] newArr = new int[arr.Length + 1];
            int conv = Decimal.ToInt32(arr.Length / 2);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < conv) newArr[i] = arr[i];
                if (i == conv) newArr[i] = Numv;
                if (i >= conv) newArr[i + 1] = arr[i];

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
<<<<<<< Updated upstream
                Console.Write(array[i] + "  ");
=======
                Console.WriteLine(e.Message);
                return -1;
>>>>>>> Stashed changes
            }
            Console.WriteLine();
            Console.WriteLine("Your reverse Array is: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + "  ");
            }
            return array[0];
        }
         static int BinarySearch(int[] arr,int left,int right, int key)
        {
<<<<<<< Updated upstream
            int middle = (left + right) / 2;

            if (left <= right)
            {
                if (arr[middle] == key)
                {
                    return  middle;
                }
                if (arr[middle] > key)
                {
                    return BinarySearch(arr , left , middle-1 , key);
                }
                else
                    return BinarySearch(arr, middle + 1,right, key);
            }
            return middle;
         /*   int[] PassedArray = arr;
            int Value = key;

            int myIndex = 0 ;
            for (int i = 0; i < PassedArray.Length; i++)
            {
                if (PassedArray[i] == Value)
                {
                    myIndex = i;
                    break;
                }
                else
                {
                    myIndex = -1;
                }
            }
            Console.WriteLine(myIndex); */
           
        }
    }
    }
=======

            static void Main(string[] args)
            {

                Console.WriteLine("Hello World!");

                //LinkedList llist = new LinkedList();

                //llist.Insert(20);
                //llist.Insert(4);
                //llist.Insert(15);
                //llist.Insert(35);
                //llist.kthFromEnd(1);


                //Console.WriteLine("input the length of your array");
                //int a = Convert.ToInt32(Console.ReadLine());
                //int[] arr = new int[a];
                //Console.WriteLine("input the the number to fill your array");

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    arr[i] = Convert.ToInt32(Console.ReadLine());
                //}

                //Console.WriteLine("input the number to insert and shift to your array");
                //int b = Convert.ToInt32(Console.ReadLine());


                //Console.WriteLine("Now we need to fill your array");
                //int[] array = new int[b];
                //for (int i = 0; i < array.Length; i++)
                //{
                //    Console.WriteLine($"Please enter the index {i + 1} of your array");
                //    array[i] = Convert.ToInt32(Console.ReadLine());
                //}
                //reverseArray(array);

                //insertShiftArray(arr, b);

                int[] array1 = { 4, 10, 15, 26, 38, 65 };
                int key = 26;
                Console.WriteLine($"BinarySearch   { BinarySearch(array1, key)}");

            }



                static int[] insertShiftArray(int[] arr, int Numv)
                {

                    int[] newArr = new int[arr.Length + 1];
                    int conv = Decimal.ToInt32(arr.Length / 2);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i < conv) newArr[i] = arr[i];
                        if (i == conv) newArr[i] = Numv;
                        if (i >= conv) newArr[i + 1] = arr[i];

                    }
                    for (int i = 0; i < newArr.Length; i++)
                    {
                        Console.Write(newArr[i] + " ");

                    }
                    return newArr;
                }



                 static int reverseArray(int[] array)
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
                static int BinarySearch(int[] arr, int key)
                {
                    int start = 0;
                    int end = arr.Length - 1;
                    while (start <= end)
                    {
                        int middle = (start + end) / 2;
                        if (arr[middle] == key)
                        {
                            return middle;
                        }
                        if (arr[middle] < key)
                        {
                            start = middle + 1;
                        }
                        else
                        {
                            end = middle - 1;
                        }
                    }
                    return -1;
                }
            }
        }
    }

>>>>>>> Stashed changes
