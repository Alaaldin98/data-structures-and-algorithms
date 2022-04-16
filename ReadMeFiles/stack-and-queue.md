## Stacks and Queues

**Stack** : Is a linear data structure which follows a particular order in which the operations are performed. The order may be LIFO(Last In First Out) or FILO(First In Last Out).

**Queue** : Is an abstract data structure, somewhat similar to Stacks. Unlike stacks, a queue is open at both its ends. One end is always used to insert data (enqueue) and the other is used to remove data (dequeue). Queue follows First-In-First-Out methodology, i.e., the data item stored first will be accessed first.


###  Node Class

```C#
 public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

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
        public Node top { get; set; }

        public Stack()
        {
            this.top = null;
        }
     }
```

#### methods:

**push**
```C#
 public void push(int value)
        {
            Node temp = new Node();
            temp.Value = value;

            if (IsEmpty())
            {
                top = temp;
            }
            else
            {
                temp.Next = top;
                top = temp;
            }
        }
```
**pop**
```C#
 public int pop()
        {
             try
            {
                Node temp = top;
                top = top.Next;
                temp.Next = null;
                return temp.Value;
            }
            catch (NullReferenceException e)
            {
                return null;
            }
        }
```

**peek**
```C#
public int peek()
        try
            {
                return top.Value;
            }
            catch (NullReferenceException)
            {
                return null;
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
        public Node front { get; set; }
        public Node rear { get; set; }
        public Queue()
        {
            this.front = null;
            this.rear = null;
        }
}

```

#### methods:

**enqueue**
```C#
public void enqueue(int value)
        {
             Node temp = new Node();
            temp.Value = value;
            if (IsEmpty())
            {
                front = temp;
                rear = temp;
            }
            else
            {
                rear.Next = temp;
                rear = temp;
            }
        }
```


**dequeue**
```C#
 public int dequeue()
        {
            try
            {
                Node temp = new Node();
                temp = front;
                front = front.Next;
                temp.Next = null;
                return temp.Value;
            }
            catch (NullReferenceException e)
            {
                return null;
            }
        }
```

**peek**
```C#
 public int peek()
        {
            try
            {
                return front.Value;
            }
            catch (NullReferenceException)
            {
                return null;
            }
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

