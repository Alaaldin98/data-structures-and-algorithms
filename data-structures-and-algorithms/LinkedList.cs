using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
