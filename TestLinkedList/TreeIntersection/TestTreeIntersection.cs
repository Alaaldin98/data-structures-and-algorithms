using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace data_structures_and_algorithms.trees
{
    public class TestTreeIntersection
    {
        [Fact]
        public void Test1()
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(13);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            BinarySearchTree tree2 = new BinarySearchTree();
            tree2.root = new Node(11);
            tree2.root.left = new Node(23);
            tree2.root.right = new Node(3);
            tree2.root.left.left = new Node(6);
            tree2.root.left.right = new Node(5);

            Tree_Intersection tree_Intersection = new Tree_Intersection();
           
            
           
        }
        [Fact]
        public void Test2()
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(13);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            BinarySearchTree tree2 = new BinarySearchTree();
            tree2.root = new Node(11);
            tree2.root.left = new Node(23);
            tree2.root.right = new Node(3);
            tree2.root.left.left = new Node(6);
            tree2.root.left.right = new Node(5);

            Tree_Intersection tree_Intersection = new Tree_Intersection();
         
        }
        [Fact]
        public void Test3()
        {

            BinarySearchTree tree = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();
            tree.root = null;
            tree2.root = new Node(11);
            Tree_Intersection tree_Intersection = new Tree_Intersection();
        
        }
    }
}
