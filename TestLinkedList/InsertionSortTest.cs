using System;
using Xunit;
using InsertionSort;

namespace TestInsertionSort
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
           
            int[] arr = { 8, 4, 23, 42, 16, 15 };
         

            Insertion.Insertionsort(arr);

            int[] arr2 = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(arr2, arr);
        }
    }
}