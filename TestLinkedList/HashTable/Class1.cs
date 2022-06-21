using System;
using System.Linq;
using Xunit;
using data_structures_and_algorithms.HashTable;

namespace TestLinkedList.HashTable
{

    public class HashTablesTest
    {
        HashTables hashTable = new HashTables(1024);
        //Setting a key/value to hashtable 
        [Fact]
        public void Test1()
        {
            hashTable.Set("1", "Cat");
            hashTable.Set("2", "Dog");
            hashTable.Set("3", "Fish");

            Assert.Equal("Cat", hashTable.Get("1").Value);
        }

        //Retrieving based on a key returns the value stored
        [Fact]
        public void Test2()
        {
            hashTable.Set("1", "Cat");
            hashTable.Set("2", "Dog");
            Assert.True(hashTable.Contains("2"));
        }
        //Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void Test3()
        {
            HashTables hashTable1 = new HashTables(1024);
            Assert.Null(hashTable1.Get("3"));
        }
    }
}
