using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{

    internal class Class2
    {
        static void Main()
        {
            LinkedList l1 = new LinkedList();
            l1.Add(new Node("1"));  
            l1.Add(new Node("2"));
            l1.Add(new Node("3"));
            l1.Add(new Node("4"));
            l1.Add(new Node("5"));
            l1.Add(new Node("8"));
            l1.Add(new Node("100"));
            l1.Add(new Node("120"));


            LinkedList l2 = new LinkedList();
            l2.Add(new Node("10"));
            l2.Add(new Node("30"));
            l2.Add(new Node("34"));
            LinkedList list = new LinkedList();
            list.MergeSortedList(l1.Head, l2.Head);
            Console.WriteLine(list.MergeSortedList(l1.Head, l2.Head));
           // list.PrintNodes();
            Console.ReadLine();
        }

        
        public class Node
        {
            public object data;
            public Node next;
            public Node(object data)
            {
                this.data = data;
            }
        }
        public class LinkedList
        {
            Node head;
            Node current;
            public Node Head //Expose a public property to get to head of the list  
            {
                get { return head; }
            }
            public void Add(Node n)
            {
                if (head == null)
                {
                    head = n; // point head to first added node  
                    current = head; // set current to head  
                }
                else
                {
                    current.next = n; //Set current next to newly added node.  
                    current = current.next;  //Set new current to current next.  
                }
            }
            public object MergeSortedList(Node first, Node second)
            {
                // We would be always adding nodes from the second list to the first one  
                // If second node head data is more than first one exchange it  
                if (Convert.ToInt32(first.next.data.ToString())
                        > Convert.ToInt32(second.data.ToString()))
                {
                    Node t = first;
                    first = second;
                    second = t;
                }
                head = first; //Assign head to first node  
                              //We need to assign head to first because first will continuosly be changing and so we want to store the beginning of list in head.  
                while ((first.next != null) && (second != null))
                {
                    if (Convert.ToInt32(first.next.data.ToString())
                        < Convert.ToInt32(second.data.ToString()))
                    {
                        first = first.next; //Iterate over the first node  
                    }
                    else
                    {
                        Node n = first.next;
                        Node t = second.next;
                        first.next = second;
                        second.next = n;
                        first = first.next;
                        second = t;
                    }
                }
                if (first.next == null) // Means there are still some elements in second  
                    first.next = second;
                return first;
            }
           
        }

    }
}
