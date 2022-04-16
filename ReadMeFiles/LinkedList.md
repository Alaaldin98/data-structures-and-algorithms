# Singly Linked List 

- Singly linked lists contain nodes which have a data part and an address part, i.e., Next, which points to the next node in the sequence of nodes. The next pointer of the last node will point to null.



## Creating a Singly Linked List

### 1- Node Class

```C#
 public class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
```

- Value type is int.
- Next is refrence for next node.
- Create constractor with node value and address of next node and is initialized to null.


### 2- LinkedList Class


```C#
public class LinkedList
    {
        public Node head;
    }
```

- When Linked List first time head (first node) is null .

### LinkedList Class methods

###### Insert


```C#
public void Insert(int value)
        {
            Node data = new Node(value);
            data.next = head;
            head = data;
        }
```
1. Create new object from Node class and give it value want to inserted.
2. Put newNode first index its have O(1) Time .
3. Make newNode is head .

###### includes

```C#
 public bool Include(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (value.Equals(current.value))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
```

1. Create current variable Node class type to hold the current node.
2. Looping over all nodes .
3. If current.value equale parameter then this Linke list include this value and return true.
4. Finally get the next node 
5. If value not found return false.

###### To String


```C#
 public string Tostring()
        {
            string stri = "";
            Node current = head;
            while (current != null)
            {
                stri += $"[ {current.value} ] -> ";
                current = current.next;
            }

            stri += "NULL";
            return stri;
        }
```

## Tests

- [x] Can successfully instantiate an empty linked list.
- [x] Can properly insert into the linked list.
- [x] The head property will properly point to the first node in the linked list.
- [x] Can properly insert multiple nodes into the linked list.
- [x] Test to return true when finding a value within the linked list that exists.
- [x] Test to return false when searching for a value in the linked list that does not exist.
- [x] Can properly return a collection of all the values that exist in the linked list.