//using System;
//using System.Collections.Generic;
//using Xunit;
//using data_structures_and_algorithms.QuickSort;

//namespace TestLinkedList
//{
//    public partial class QuickSortTests
//    {

//        [Fact]
//        public void QuickSort_WithDistinctValues()
//        {
//            QuickSort()
//        }


//        [Fact]
//        public void QuickSort_WithDuplicateValues()
//        {
//            var values = new List<int>(Constants.ArrayWithDuplicateValues);
//            QuickSort.Sort(values, 0, values.Count - 1);
//            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
//        }


//        [Fact]
//        public void QuickSort_WithSortedDistinctValues()
//        {
//            var values = new List<int>(Constants.ArrayWithSortedDistinctValues);
//            QuickSort.Sort(values, 0, values.Count - 1);
//            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
//        }


//        [Fact]
//        public void QuickSort_WithSortedDuplicateValues()
//        {
//            var values = new List<int>(Constants.ArrayWithSortedDuplicateValues);
//            QuickSort.Sort(values, 0, values.Count - 1);
//            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
//        }


//        [Fact]
//        public void QuickSort_WithReverselySortedDistinctValues()
//        {
//            var values = new List<int>(Constants.ArrayWithReverselySortedDistinctValues);
//            QuickSort.Sort(values, 0, values.Count - 1);
//            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
//        }


//        [Fact]
//        public void QuickSort_WithReverselySortedDuplicateValues()
//        {
//            var values = new List<int>(Constants.ArrayWithReverselySortedDuplicateValues);
//            QuickSort.Sort(values, 0, values.Count - 1);
//            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
//        }
//    }
//}


