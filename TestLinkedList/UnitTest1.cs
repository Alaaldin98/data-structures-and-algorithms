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
      

        // Test if k is not at the end, but somewhere in the middle of the linked list
        [Fact]
        public void Test5()
        {
            LinkedList list = new LinkedList(1);
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(3, list.kthFromEnd(2));

        }

    }
}