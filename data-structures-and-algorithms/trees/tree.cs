using System.Collections.Generic;

namespace data_structures_and_algorithms.trees
{



    public class BinaryTree
    {
        public List<int> list = new List<int>();
        public BinaryTree()
        {
            root = null;
        }

        public Node root { get; set; }
        public void preOrder(Node root)
        {
            if (root.left != null)
                preOrder(root.left);
            if (root.right is not null)
                preOrder(root.right);
        }
        public int[] inOrder(Node root)
        {
            if (root.left != null)
                inOrder(root.left);
            if (root.right is not null)
                inOrder(root.right);
            return list.ToArray();
        }
        public int[] postOrder(Node root)
        {
            if (root.left != null)
                postOrder(root.left);
            if (root.right is not null)
                postOrder(root.right);
            return list.ToArray();
        }
        public static int findMax(Node node)
        {

            if (node == null)
            {
                return int.MinValue;
            }

            int res = node.value;
            int lres = findMax(node.left);
            int rres = findMax(node.right);

            if (lres > res)
            {
                res = lres;
            }
            if (rres > res)
            {
                res = rres;
            }
            return res;
        }
    }
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            Node before = null;

            Node after = this.root;

            while (after != null)
            {
                before = after;
                if (value < after.value)
                    after = after.left;
                else if (value > after.value)
                    after = after.right;
            }

            Node newNode = new Node(value);

            if (this.root == null)
                this.root = newNode;
            else
            {
                if (value < before.value)
                    before.left = newNode;
                else
                    before.right = newNode;
            }
        }
        public bool Contains(int value)
        {
            if (root == null)
            {
                return false;
            }

            Node current = root;

            while (current != null)
            {
                if (current.value == value)
                {
                    return true;
                }
                else if (value < current.value)
                {
                    current = current.left;
                }
                else if (value > current.value)
                    current = current.right;
            }

            return false;
        }

    }
}
