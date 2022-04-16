# Linked List kth

### 1- Node Class

```C#
 public class Node
   {
        public int value { get; set; }
        public Node next { get; set; }
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
```

### 2- LinkedList Class


```C#
public class LinkedList
    {
       public Node head { get; set; }
        public LinkedList(int value)
        {
            head = new Node(value);
        }
    }
```

- When Linked List first time head (first node) is null .

### LinkedList Class methods


###### Kth

****Time Complexity**** : O(n)

```C#
 public int kthFromEnd(int n)
        { 
                int len = 0;
                Node temp = head;

                // 1) count the number of nodes in Linked List
                while (temp != null)
                {
                    temp = temp.next;
                    len++;
                }

                // check if value of n is not more than length of
                // the linked list
                if (len < n)
                    return 1;
                temp = head;

                // 2) get the (len-n+1)th node from the beginning
                for (int i = 1; i < len - n + 1; i++)
                    temp = temp.next;
                Console.WriteLine(temp.value);
                return temp.value;
        }

```


## Tests

- [x] Where k is greater than the length of the linked list
- [x] Where k and the length of the list are the same
- [x]Where k is not a positive integer
- [x] Where the linked list is of a size 1
- [x] “Happy Path” where k is not at the end, but somewhere in the middle of the linked list




### whiteboard

![Flowchart (7)](https://user-images.githubusercontent.com/98964675/161414643-abdb5c3a-9563-410d-9b54-553bc9cd9646.jpg)

##### Tests

```c#
public void LLKth()
        {
  LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(3, list.kthFromEnd(1));
            Assert.Equal(-1, list.kthFromEnd(-4));
}

```

