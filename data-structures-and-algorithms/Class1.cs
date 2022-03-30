using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    internal class Class1
    {
        public Node head { get; set; }
        public void Append(object value)
        {
            Node current = head;
            Node temp = new Node(value);

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = temp;
        }
        public void InsertBefore(object beforValue, object newValue)
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
        public void InsertAfter(object afterValue, object newValue)
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
    }
}

