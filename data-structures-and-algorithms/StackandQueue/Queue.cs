﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Queue
    {
        public Node front { get; set; }
        public Node rear { get; set; }
        public Queue()
        {
            this.front = null;
            this.rear = null;
        }

        public void Enqueue(object value)
        {
            Node temp = new Node();
            temp.value = (int)value;
            if (IsEmpty())
            {
                front = temp;
                rear = temp;
            }
            else
            {
                rear.Next = temp;
                rear = temp;
            }

        }
        public object Dequeue()
        {
            try
            {
                Node temp = new Node();
                temp = front;
                front = front.Next;
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
                return front.value;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        public bool IsEmpty()
        {
            return this.front == null;
        }
    }
}
