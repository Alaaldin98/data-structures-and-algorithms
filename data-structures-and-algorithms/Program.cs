using System;

namespace data_structures_and_algorithms
{

    public class LinkedList

    {
        public Node head { get; set; }
        public LinkedList(int value)
        {
            head = new Node(value);
        }



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
        public void Append(int newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = temp;
        }

        // Function to adds a new node with the given new value immediately before the first node that has the value specified

        public void InsertBefore(int beforValue, int newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);
            while (current != null)
            {
                if (beforValue.Equals(current.value))
                {
                    temp.next = head;
                    head = temp;
                    break;
                }

                if (beforValue.Equals(current.next.value))
                {
                    temp.next = current.next;
                    current.next = temp;
                    break;
                }
                current = current.next;
            }

        }

        // Function to adds a new node with the given new value immediately after the first node that has the value specified

        public void InsertAfter(int afterValue, int newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);

            while (current != null)
            {
                if (afterValue.Equals(current.value))
                {
                    temp.next = current.next;
                    current.next = temp;
                    break;
                }
                current = current.next;
            }
        }

        public int kthFromEnd(int n)
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
    }

    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }
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

            Console.WriteLine("Hello World!");



            int[] array1 = { 4, 10, 15, 26, 38, 65 };
            int key = 26;
            Console.WriteLine($"BinarySearch   { BinarySearch(array1, key)}");
            LinkedList linkedList = new LinkedList(8);
            linkedList.Append(key);

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


        