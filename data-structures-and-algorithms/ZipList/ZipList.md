# Challenge Summary
Linked List Zip: function that takes two lists, each of which is sorted in increasing order, and merges the two together into one list which is in increasing order. Should return the new list. The new list should be made by splicing together the nodes of the first two lists.

## Whiteboard Process

![Flowchart (12).jpg](ZipList/ZipListWhiteboard.jpg)

## Approach & Efficiency



| Method	|   Time Complexity  |	Space Complexity |
| --------- |   ------------     |   --------------  |  
| ZipLists  |       O(n)	     |       O(1)        |

## Solution




```C#
        public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.head;
            Node current2 = list2.head;

            while (current2 != null)
            {
                if (current1 == null)
                {
                    list1.Append(current2.value);
                    current2 = current2.next;
                }
                else
                {
                    current1 = current1.next;
                }
            }
            return list1;
        }
```
