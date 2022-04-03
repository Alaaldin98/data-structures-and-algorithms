using System;

namespace data_structures_and_algorithms
{
    public class LinkedList
    {
        public Node head;



        public void Insert(int value)
        {
            Node data = new Node(value);
            data.next = head;
            head = data;
        }

        public bool Include(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (value.Equals(current.value))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public string Tostring()
        {
            string stri = "";
            Node current = head;
            while (current != null)
            {
                stri += $"[ {current.value} ] -> ";
                current = current.next;
            }

            stri += "NULL";
            return stri;
        }
        public void Append(int nvalue)
        {
            Node newNode = new Node(nvalue);
            newNode.value = nvalue;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(nvalue);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;


            }


        }

        public int kthFromEnd(int n)
        {
            try
            {
                int len = 0;
                Node temp = head;

                // 1) count the number of nodes in Linked List
                while (temp != null)
                {
                    temp = temp.next;
                    len++;
                }

                // check if value of n is not more than length of
                // the linked list
                if (len < n)
                    return 1;
                temp = head;

                // 2) get the (len-n+1)th node from the beginning
                for (int i = 1; i < len - n + 1; i++)
                    temp = temp.next;
                Console.WriteLine(temp.value);
                return temp.value;
            }
            catch (Exception e)
            {
Console.WriteLine(e.Message);
                return -1;
            }
        }


        public class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Hello World!");

                    LinkedList llist = new LinkedList();

                    llist.Insert(20);
                    llist.Insert(4);
                    llist.Insert(15);
                    llist.Insert(35);
                    llist.kthFromEnd(1);
                   

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

                    int[] array = { 4, 10, 15, 26, 38, 65 };
                    int key = 26;
                    if (BinarySearch(array, 0, array.Length, key) != -1)
                    {
                        Console.WriteLine(BinarySearch(array, 0, array.Length, key));
                    }
                    else
                        Console.WriteLine(-1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);


                }


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
            static int BinarySearch(int[] arr, int left, int right, int key)
            {
                int middle = (left + right) / 2;

                if (left <= right)
                {
                    if (arr[middle] == key)
                    {
                        return middle;
                    }
                    if (arr[middle] > key)
                    {
                        return BinarySearch(arr, left, middle - 1, key);
                    }
                    else
                        return BinarySearch(arr, middle + 1, right, key);
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
}
