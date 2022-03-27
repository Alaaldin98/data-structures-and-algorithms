using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
     class LinkedList
    {
        Node Head;
        Node Last;
        public LinkedList()
        {
            Head = Last = null;
           
        }
        public void AddEnd(int value)
        {
            Node item = new Node(value);
            if(Head == null)
            {
                Head = item;
                Last = item;
            }
            else
            {
                Last.Next = item;
                Last = item;
            }            
        }
        public void AddFirst(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Last = item;
            }
            else
            {
               item.Next = Head;
                Head = item;
            }
        }
        public void Display()
        {
            Node Start = Head;
            if (Start == null)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                while (Start != null)
                {
                    Console.WriteLine(Start.Data);
                    Start = Start.Next;
                }
            }
        }
    }
}
