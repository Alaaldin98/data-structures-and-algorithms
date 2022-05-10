﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Stack
    {
        public Node top { get; set; }

        public Stack()
        {
            this.top = null;
        }

        public void Push(object value)
        {
            Node temp = new Node();
            temp.value = (int)value;

            if (IsEmpty())
            {
                top = temp;
            }
            else
            {
                temp.Next = top;
                top = temp;
            }

        }

        public object Pop()
        {
            try
            {
                Node temp = top;
                top = top.Next;
                temp.Next = null;
                return temp.value;
            }
            catch (NullReferenceException e)
            {
                return null;
            }

        }

        public object Peek()
        {
            try
            {
                return top.value;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public bool IsEmpty()
        {
            return top == null;
        }
        
    }
}
