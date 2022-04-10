## Stacks and Queues

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
###### Stack Methods

| Method  | Time Complexity | Space Complexity |
| -------- | --------- | --------- |
| Push  | O(1) |  O(1) |
| Push  |	O(1)   |	O(1)  |
| Pop | O(1) | O(1) |
| Peek | O(1) | O(1) |
| IsEmpty | O(1) | O(1) |

###### Queue Methods


| Method  | Time Complexity | Space Complexity |
| -------- | --------- | --------- |
| Enqueue  | O(1) |  O(1) |
| Dequeue  | O(1) |  O(1) |
| Peek  | O(1) |  O(1) |
| IsEmpty  | O(1) |  O(1) |



### Stack

```C#
 public class Stack
    {
        public Node top;
        public Node bottom;
        public int length;

        public Stack()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }
    }
```

#### methods:

**push**
```C#
 public void push(int value)
        {
            Node newNode = new Node(value);
            if (this.length == 0)
            {
                this.top = newNode;
                this.bottom = newNode;
            }
            else
            {
                Node holdingPointer = this.top;
                this.top = newNode;
                this.top.next = holdingPointer;
            }
            this.length++;
        }
```
**pop**
```C#
 public int pop()
        {
            if (this.top == null)
            {
                return -100000;
            }
            Node holdingPointer = this.top;
            this.top = this.top.next;
            this.length--;
            return holdingPointer.value;
        }
```

**peek**
```C#
public int peek()
        {
            if (this.length > 0)
                return this.top.value;
            return -100000; //returning -100000 if length is 0
        }
```

**is empty**
```C#
 public bool IsEmpty()
        {
            return top == null;
        }
```

### Queue

```C#
{
        public Node first;
        public Node last;
        public int length;

        public Queue()
        {
            this.first = null;
            this.last = null;
            this.length = 0;
        }
}

```

#### methods:

**enqueue**
```C#
public void enqueue(int value)
        {
            Node newNode = new Node(value);
            if (this.length == 0)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.next = newNode;
                this.last = newNode;
            }
            this.length++;
        }
```


**dequeue**
```C#
 public int dequeue()
        {
            if (this.first == null)
            {
                return -1111111;
            }
            if (this.length == 0)
            {
                this.last = null;
            }
            Node holdingPointer = this.first;
            this.first = this.first.next;

            this.length--;

            return holdingPointer.value;
        }
```

**peek**
```C#
 public int peek()
        {
            if (this.length > 0)
            {
                return this.first.value;
            }
            return -111111;  //returining large negative value if length is 0.
        }
```

**is empty**
```C#
        public bool IsEmpty()
        {
            return this.first == null;
        }
```



### Tests

- [x] Can successfully push onto a stack
- [x] Can successfully push multiple values onto a stack
- [x] Can successfully pop off the stack
- [x] Can successfully empty a stack after multiple pops
- [x] Can successfully peek the next item on the stack
- [x] Can successfully instantiate an empty stack
- [x] Calling pop or peek on empty stack raises exception
- [x] Can successfully enqueue into a queue
- [x] Can successfully enqueue multiple values into a queue
- [x] Can successfully dequeue out of a queue the expected value
- [x] Can successfully peek into a queue, seeing the expected value
- [x] Can successfully empty a queue after multiple dequeues
- [x] Can successfully instantiate an empty queue
- [x] Calling dequeue or peek on empty queue raises exception

