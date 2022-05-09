using data_structures_and_algorithms.trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.FizzBuzzTree
{
   
    public class fizzbuzztree
    {
        public static Node Root;


        public void FizzBuzzTree()
        {
            Traverse(Root);
        }
        public List<string> Traverse(Node node)
        {
            if (Root == null)
            {
                throw new Exception("Tree is empty");
            }
            List<string> list = new List<string>();
            if(node.value % 15 == 0)
            {
                list.Add("FizzBuzz");
            } else if(node.value % 5 == 0)
            {
                list.Add("Buzz");
            } else if(node.value % 3 == 0)
            {
                list.Add("Fizz");
            }
            else
            {
                list.Add($"{node.value}");
            }
            if(node.left != null)
            {
                Traverse(node.left);
            }if(node.right != null)
            {
                Traverse(node.right);
            }
            return list;
           
        }
    }
}
