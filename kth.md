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

