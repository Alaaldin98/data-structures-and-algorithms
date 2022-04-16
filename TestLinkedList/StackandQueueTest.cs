using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using data_structures_and_algorithms;


namespace TestLinkedList
{
    public class StackandQueueTest
    {
       
        [Fact]
        public void Testpush()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.top.Value);
        }


        [Fact]
        public void Testpushmultiplevalues()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.top.Value);
        }

        [Fact]
        public void Testpop()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void Testempty()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Pop();
            Assert.Null(stack.Pop());
        }

        [Fact]
        public void Testpeek()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            Assert.Equal(2, stack.Peek());
        }

        [Fact]
        public void Testinstantiate()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void Testpeekfromemptystack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peek());
        }

        [Fact]
        public void Testenqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            Assert.Equal(1, queue.front.Value);
        }

        [Fact]
        public void Testenqueuemultiple()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(3, queue.rear.Value);
        }

        [Fact]
        public void Testdequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            Assert.Equal(1, queue.Dequeue());
        }

        [Fact]
        public void Testtopeek()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void Testemptym()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();
            Assert.Null(queue.Dequeue());
        }

        [Fact]
        public void Testtodequeue()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Dequeue());
        }
    }
}
