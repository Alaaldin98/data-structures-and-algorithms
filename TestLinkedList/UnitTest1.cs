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
            LinkedList linked = new LinkedList();
            Assert.Null(linked.head);
        }

        [Fact]
        public void Test2()
        {
            LinkedList linked = new LinkedList();
            linked.Insert(15);
            Assert.True(linked.Include(15));
        }

        [Fact]
        public void Test3()
        {
            LinkedList linked = new LinkedList();
            linked.Insert(5);
            linked.Insert(17);
            Assert.Equal(17, linked.head.value);
        }
        [Fact]
        public void Test4()
        {
            LinkedList linked = new LinkedList();
            linked.Insert(5);
        
            linked.Insert(10);
            Assert.True(linked.Include(10));
        }

        [Fact]
        public void Test5()
        {
            LinkedList linked = new LinkedList();
            linked.Insert(20);
            linked.Insert(4);
            linked.Insert(6);
            Assert.True(linked.Include(20));
        }

        [Fact]
        public void Test6()
        {
            LinkedList linked = new LinkedList();
            linked.Insert(80);
            linked.Insert(13);
            linked.Insert(50);
            Assert.False(linked.Include(120));
        }

        [Fact]
        public void Test7()
        {
            LinkedList linked = new LinkedList();
            linked.Insert(20);
            linked.Insert(8);
            linked.Insert(27);
            Assert.Equal("[ 27 ] -> [ 8 ] -> [ 20 ] -> NULL", linked.Tostring());
        }
        [Fact]
        public void Test8()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(3, list.kthFromEnd(1));
            Assert.Equal(-1, list.kthFromEnd(-4));
        }
    }
}