using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Node
    {
        public object value;
        public Node next;

        public Node(object value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
