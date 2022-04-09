# Linked List insertions




###  Node Class

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

###### Append
Append : Need to adds a new node with the given value to the end of the list, need to cross all node in list and add node in the last .

****Time Complexity**** : O(n)
```C#
 public void Append(int newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = temp;
        }
```

1. Make current Node is head.
2. Create new object from Node class and give it value newValue .
3. Loop overall LinkedList if current.next not equal null.
4. Inside while loop make the value of current is equal current.next .
5. Make the value of current.next is equal temp .

###### InsertBefore

Insert before : Need to adds a new node with the given new value immediately before the first node that has the value specified.
 
****Time Complexity**** : O(n)

```C#
  public void InsertBefore(int beforValue, int newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);
            while (current != null)
            {
                if (beforValue.Equals(current.value))
                {
                    temp.next = head;
                    head = temp;
                    break;
                }

                if (beforValue.Equals(current.next.value))
                {
                    temp.next = current.next;
                    current.next = temp;
                    break;
                }
                current = current.next;
            }

        }
```


1. Make current Node is head.
2. Create new object from Node class and give it value newValue .
3. Loop overall LinkedList if current not equal null.
4. Inside while loop make two if condition.
5. if beforValue Equal current.value .
6. Make temp.next = head &  head = temp
7. break to stop loop.
8. if beforValue Equal current.next.value .
9. Make temp.next = current.next & current.next = temp
10. break to stop loop.
                    
           

###### InsertAfter


Insert after: Need to adds a new node with the given new value immediately after the first node that has the value specified.

****Time Complexity**** : O(n)

```C#
public void InsertAfter(int afterValue, int newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);

            while (current != null)
            {
                if (afterValue.Equals(current.value))
                {
                    temp.next = current.next;
                    current.next = temp;
                    break;
                }
                current = current.next;
            }
        }
```

1. Make current Node is head.
2. Create new object from Node class and give it value newValue .
3. Loop overall LinkedList if current not equal null.
4. Inside while loop make if condition.
5. if afterValue Equal current.value .
6. Make temp.next = current.next &  current.next = temp
7. break to stop loop.
8. current = current.next.


## Tests


```C#
def Test1():
    LinkedList list = new LinkedList(8);
    expected = 11
    actual = list.Append(11);
    assert expected is actual, list.head.next.value
```

```C#
def Test2():
    LinkedList list = new LinkedList(8);
    list.Append(9);
    list.Append(10);
    expected = 10
    actual = list.Append(10);
    assert expected is (actual, list.head.next.next.value)
```
```C#
def Test3():
    LinkedList list = new LinkedList(8);
            list.Append(7);
            list.Append(10);
            expected = 5
            actual = list.InsertBefore(7,5);
            assert expected is (actual, list.head.next.value);
```
```C#
def Test4():
     LinkedList list = new LinkedList(8);
            expected = 5
            actual = list.InsertBefore(8, 5);
            assert expected is (actual,list.head.value);
```
```C#
def Test5():
      LinkedList list = new LinkedList(8);
            list.Append(9);
            list.Append(10);
            expected = 5
            actual = list.InsertAfter(9, 5);
            assert expected is (actual,list.head.next.next.value);
```
```C#
def Test6():
      LinkedList list = new LinkedList(8);
            expected = 5
            actual = list.InsertAfter(8, 5);
            assert expected is (actual,list.head.next.value);
```





- [x] Can successfully add a node to the end of the linked list
- [x] Can successfully add multiple nodes to the end of a linked list
- [x] Can successfully insert a node before a node located i the middle of a linked list
- [x] Can successfully insert a node before the first node of a linked list
- [x] Can successfully insert after a node in the middle of the linked list
- [x] Can successfully insert a node after the last node of the linked list
