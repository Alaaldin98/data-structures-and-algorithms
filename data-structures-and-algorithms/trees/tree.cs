﻿namespace data_structures_and_algorithms.trees
{
    internal class tree
    {
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

        public class BinaryTree
        {
            public void preOrder(Node root)
            {
                if (root.left != null)
                    preOrder(root.left);
                if (root.right is not null)
                    preOrder(root.right);
            }
            public void inOrder(Node root)
            {
                if (root.left != null)
                    inOrder(root.left);
                if (root.right is not null)
                    inOrder(root.right);
            }
            public void postOrder(Node root)
            {
                if (root.left != null)
                    postOrder(root.left);
                if (root.right is not null)
                    postOrder(root.right);
            }
        }
        class BinarySearchTree
        {
            private Node root;
            public BinarySearchTree()
            {
                this.root = null;
            }

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
        }
    }
}