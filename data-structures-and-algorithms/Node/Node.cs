﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Node
    {
        public Node left { get; set; }
        public Node Next { get; set; }
        public Node right { get; set; }
        public int value { get; set; }
        public int Data { get; set; }

        public  Node(int value)
        {
            this.left = null;
            this.right = null;
            this.value = value;
            this.Data = value;
            this.Next = null;
        }

        public Node()
        {
        }


    }
}
