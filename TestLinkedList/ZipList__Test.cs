//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;
//using data_structures_and_algorithms;




//namespace TestLinkedList
//{
//    public class ZipList__Test
//    {
//        [Fact]
//        public void Test1()
//        {
//            LinkedList list = new LinkedList(3);
//            list.Append(1);
//            list.Append(3);
//            list.Append(2);


//            LinkedList list1 = new LinkedList(3);
//            list1.Append(5);
//            list1.Append(9);
//            list1.Append(4);


//            LinkedList list2 = new LinkedList(3);
//            list2.Append(1);
//            list2.Append(5);
//            list2.Append(3);

//            LinkedList zip = LinkedList.ZipLists(list, list1);

//            Assert.Equal(zip.head.next.value, list2.head.next.value);
//        }

//    }
//}
