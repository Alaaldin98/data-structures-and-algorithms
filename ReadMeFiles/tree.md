# Trees
###### Trees are branching data structures. They are often visualized top down from a single root node that has a left child and a right child. Both of these children nodes can have their own left and right children. This pattern can continue on indefinitely until a massive tree-like structure is formed (albeit visualized upside down). Traditionally trees only have right and left children. Since there are two it is referred to as a binary tree.

## Challenge
- ##### Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
- ##### Create a Binary Tree class


1.  pre order
2. in order
3. post order which returns an array of the values, ordered appropriately.

- ##### Create a Binary Search Tree class
1. **Add**
Arguments: value
Return: nothing
Adds a new node with that value in the correct location in the binary search tree.
2. **Contains**
Argument: value
Returns: boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency

| Method  | Time Complexity | Space Complexity |
| -------- | --------- | --------- |
| preOrder  | O(n) |  O(1) |
| inOrder  | O(n) |  O(1) |
| postOrder  | O(n) |  O(1) |
| ___ | ___ |  ___ |
| Add  | O(n) |  O(1) |
| Contains  | O(n) |  O(1) |
## API

### Node 
```C#
 public class Node
        {
            public Node left { get; set; }
            public Node right { get; set; }
            public int value { get; set; }

            public Node(int value)
            {
                this.left = null;
                this.right = null;
                this.value = value;
            }
        }
```
### Binary Tree method
#### preOrder
```C#
 public void preOrder(Node root)
            {
                if (root.left != null)
                    preOrder(root.left);
                if (root.right is not null)
                    preOrder(root.right);
            }
```
#### inOrder
```C#
            public void inOrder(Node root)
            {
                if (root.left != null)
                    inOrder(root.left);
                if (root.right is not null)
                    inOrder(root.right);
            }
```
#### postOrder
```C#
            public void postOrder(Node root)
            {
                if (root.left != null)
                    postOrder(root.left);
                if (root.right is not null)
                    postOrder(root.right);
            }
```
### Binary Search Tree method

```C#
 public void Add(int value)
            {
                Node newNode = new Node(value);
                if (this.root == null)
                {
                    this.root = newNode;
                    return;
                }

                Node currentNode = this.root;
                while (true)
                {
                    if (currentNode.value > value)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = new Node(value);
                            return;
                        }
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = new Node(value);
                            return;
                        }
                        currentNode = currentNode.right;
                    }
                }
            }
```
```C#
            public bool Contains(int value)
            {
                if (root != null)
                {
                    if (root.value == value)
                    {
                        return true;
                    }
                    else if (root.value > value)
                    {
                        return Contains(value);
                    }
                    else if (root.value < value)
                    {
                        return Contains(value);
                    }
                }
                return false;
            }
        ```
