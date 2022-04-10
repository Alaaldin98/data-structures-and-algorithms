using System;
using Xunit;
using data_structures_and_algorithms;

namespace TestLinkedList
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            LinkedList linked = new LinkedList(8);
            Assert.Null(linked.head);
        }

        [Fact]
        public void Test2()
        {
            LinkedList linked = new LinkedList(8);
            linked.Insert(15);
            Assert.True(linked.Include(15));
        }

        [Fact]
        public void Test3()
        {
            LinkedList linked = new LinkedList(8);
            linked.Insert(5);
            linked.Insert(17);
            Assert.Equal(17, linked.head.value);
        }
        [Fact]
        public void Test4()
        {
            LinkedList linked = new LinkedList(8);
            linked.Insert(5);

            linked.Insert(10);
            Assert.True(linked.Include(10));
        }

        [Fact]
        public void Test5()
        {
            LinkedList linked = new LinkedList(8);
            linked.Insert(20);
            linked.Insert(4);
            linked.Insert(6);
            Assert.True(linked.Include(20));
        }

        [Fact]
        public void Test6()
        {
            LinkedList linked = new LinkedList(8);
            linked.Insert(80);
            linked.Insert(13);
            linked.Insert(50);
            Assert.False(linked.Include(120));
        }

        [Fact]
        public void Test7()
        {
            LinkedList linked = new LinkedList(8);
            linked.Insert(20);
            linked.Insert(8);
            linked.Insert(27);
            Assert.Equal("[ 27 ] -> [ 8 ] -> [ 20 ] -> NULL", linked.Tostring());
        }

    }
    public class UnitTest2
    {
        //Add a node to the end of the linked list
        [Fact]
        public void Test1()
        {
            LinkedList list = new LinkedList(8);
            list.Append(9);
            Assert.Equal(9, list.head.next.value);
        }

        //Add multiple nodes to the end of a linked list
        [Fact]
        public void Test2()
        {
            LinkedList list = new LinkedList(8);
            list.Append(9);
            list.Append(10);
            Assert.Equal(10, list.head.next.next.value);
        }

        //Insert a node before a node located i the middle of a linked list
        [Fact]
        public void Test3()
        {
            LinkedList list = new LinkedList(8);
            list.Append(9);
            list.Append(10);
            list.InsertBefore(9, 5);
            Assert.Equal(5, list.head.next.value);
        }

        //Insert a node before the first node of a linked list
        [Fact]
        public void Test4()
        {
            LinkedList list = new LinkedList(8);
            list.InsertBefore(8, 5);
            Assert.Equal(5, list.head.value);
        }

        //Insert after a node in the middle of the linked list
        [Fact]
        public void Test5()
        {
            LinkedList list = new LinkedList(8);
            list.Append(9);
            list.Append(10);
            list.InsertAfter(9, 5);
            Assert.Equal(5, list.head.next.next.value);
        }
        //Insert a node after the last node of the linked list
        [Fact]
        public void Test6()
        {
            LinkedList list = new LinkedList(8);
            list.InsertAfter(8, 5);
            Assert.Equal(5, list.head.next.value);
        }
    }
    public class kth
    {
        [Fact]
        public void LLKth()
        {
            LinkedList list = new LinkedList(8);
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(3, list.kthFromEnd(8));
            Assert.Equal(-1, list.kthFromEnd(-4));
        }
    }
    public class Queueandstack
    {
            //Test push onto a stack
            [Fact]
            public void Test1()
            {
                Stack stack = new Stack();
                stack.push(1);
                Assert.Equal(1, stack.top.value);
            }

            //Test push multiple values onto a stack
            [Fact]
            public void Test2()
            {
                Stack stack = new Stack();
                stack.push(1);
                stack.push(2);
                stack.push(3);
                Assert.Equal(3, stack.top.value);
            }

            //Test pop off the stack
            [Fact]
            public void Test3()
            {
                Stack stack = new Stack();
                stack.push(1);
                Assert.Equal(1, stack.pop());
            }

            //Test empty a stack after multiple pops
            [Fact]
            public void Test4()
            {
                Stack stack = new Stack();
                stack.push(1);
                stack.push(2);
                stack.pop();
                stack.pop();
                Assert.Null(stack.pop());
            }

            //Test peek the top item on the stack
            [Fact]
            public void Test5()
            {
                Stack stack = new Stack();
                stack.push(1);
                stack.push(2);
                Assert.Equal(2, stack.peek());
            }

            //Test to instantiate an empty stack
            [Fact]
            public void Test6()
            {
                Stack stack = new Stack();
                Assert.True(stack.IsEmpty());
            }

            //Test to peek from empty stack
            [Fact]
            public void Test7()
            {
                Stack stack = new Stack();
                Assert.Null(stack.peek());
            }

            //Test to enqueue into a queue
            [Fact]
            public void Test8()
            {
                Queue queue = new Queue();
                queue.enqueue(1);
                Assert.Equal(1, queue.first.value);
            }

            //Test to enqueue multiple values into a queue
            [Fact]
            public void Test9()
            {
                Queue queue = new Queue();
                queue.enqueue(1);
                queue.enqueue(2);
                queue.enqueue(3);
                Assert.Equal(3, queue.last.value);
            }

            //Test to dequeue out of a queue the expected value
            [Fact]
            public void Test10()
            {
                Queue queue = new Queue();
                queue.enqueue(1);
                Assert.Equal(1, queue.dequeue());
            }

            //Test to peek into a queue
            [Fact]
            public void Test11()
            {
                Queue queue = new Queue();
                queue.enqueue(1);
                queue.enqueue(2);
                Assert.Equal(1, queue.peek());
            }

            //Test empty a queue after multiple dequeues
            [Fact]
            public void Test12()
            {
                Queue queue = new Queue();
                queue.enqueue(1);
                queue.enqueue(2);
                queue.dequeue();
                queue.dequeue();
                Assert.Null(queue.dequeue());
            }

            //Test to instantiate an empty queue
            [Fact]
            public void Test13()
            {
                Queue queue = new Queue();
                Assert.Null(queue.first.value);
            }

            //Test to dequeue or peek on empty queue raises exception
            [Fact]
            public void Test14()
            {
                Queue queue = new Queue();
                Assert.Null(queue.dequeue());
            }
        }
        }