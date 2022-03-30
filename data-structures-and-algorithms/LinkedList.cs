using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class LinkedList
    {
        public Node head;

        public void Insert(object value)
        {
            Node data = new Node(value);
            data.next = head;
            head = data;
        }

        public bool Include(object value)
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
    }
}
