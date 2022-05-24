## Insertion Sort

*Selection sort algorithm, builds a working implementation, and discusses its performance characteristics. So here comes the thing ; What is sorting? Sorting is any process of arranging items systematically, and has two commons, yet distinct meanings: ordering: arranging items in a sequence ordered by some criterion; categorizing: grouping items with similar properties. What is mean by selection sort? A sort algorithm that repeatedly searches remaining items to find the least one and moves it to its final location. The run time is Θ(n²), where n is the number of elements. The number of swaps is O(n). Selection sort is an in-place comparison sorting algorithm. This means that sorted items occupy the same storage as the original ones. Before we go any further, it’s important to note that the selection sorting algorithm is not commonly used in practice unless the dataset is small (i.e., 10–20 elements). Selection sort does usually outperform bubble sort, which is the first algorithm we looked at in this series. At a high level, selection sort divides the array into two parts: one half sorted and the other not. At the onset, the sorted section is empty, and the unsorted portion contains all of the elements. Selection sort utilizes two loops; the outer loop iterates n times, where n is the number of elements in the array. We immediately set the “min index” to the first element, and then use another loop to compare elements, swapping the min index if the adjacent element is less than the current minimum.*


Example for selective sorting: Selection sort is another algorithm that is used for sorting. This sorting algorithm, iterates through the array and finds the smallest number in the array, and swaps it with the first element if it is smaller than the first element. Next, it goes on to the second element and so on until all elements are sorted.

And how does this work: Selection sort is a simple sorting algorithm. … The smallest element is selected from the unsorted array and swapped with the leftmost element, and that element becomes a part of the sorted array. This process continues moving unsorted array boundaries by one element to the right.

Selection Sort Algorithm

1. Get a list of unsorted numbers


2. Set a marker for the unsorted section at the front of the list


3. Repeat steps 4–6 until one number remains in the unsorted section


4. Compare all unsorted numbers in order to select the smallest one


5. Swap this number with the first number in the unsorted section


6. Advance the marker to the right one position


7. Stop

##### Code

```C#
using System;

namespace InsertionSort
{
    public class Insertion
    {

        // Function to sort array
        // using insertion sort
        public static void Insertionsort(int[] arr)
        {

            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}

```

##### Test
```C#
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
```

### Efficency
#### Time: O(n^2)
The basic operation of this algorithm is comparison. This will happen n * (n-1) number of times…concluding the algorithm to be n squared.
#### Space: O(1)
No additional space is being created. This array is being sorted in place…keeping the space at constant O(1).

