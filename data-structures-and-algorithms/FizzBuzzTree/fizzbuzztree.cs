using System;
using System.Collections.Generic;
using System.Linq;

namespace data_structures_and_algorithms.FizzBuzzTree
{

    public class FNode
    {
        public int Value { get; set; }

        public List<FNode> Branch = new List<FNode>() { };
        public FNode(int Value)
        {
            this.Value = Value;

        }
        public List<FNode> getBranch()
        {
            return Branch;
        }

        public void AddBranch(FNode newFNode)
        {
            this.Branch.Add(newFNode);
        }
       
       
        public class K_Ary_Tree
        {
            public FNode Root;
            public K_Ary_Tree(FNode newFNode)
            {
                Root = newFNode;

            }
            public List<string> FizzBuzzTree(K_Ary_Tree MyKTree)
            {

                Queue<FNode> MyQueue = new Queue<FNode>();
                List<string> MyList = new List<string>();
               
                if (MyKTree.Root == null)
                {
                    throw new Exception("Tree Is Empty!");
                }
                else
                {
                    MyQueue.Enqueue(MyKTree.Root);
                    while (MyQueue.Count > 0)
                    {
                        FNode temp = MyQueue.Dequeue();
                        if (temp.Value % 3 == 0 && temp.Value % 5 == 0)
                        {
                           
                            MyList.Add("FizzBuzz");
                        }


                        else if (temp.Value % 3 == 0)
                        {
                            
                            MyList.Add("Fizz");
                        }
                        else if (temp.Value % 5 == 0)
                        {
                           
                            MyList.Add("Buzz");
                        }

                        else
                        {
                            MyList.Add(temp.Value.ToString());
                           
                        }
                        if (temp.Branch.Count > 0)
                        {
                            foreach (var child in temp.Branch)
                            {
                                MyQueue.Enqueue(child);
                            }
                        }
                    }
                    return MyList;

                }
            }
        }
    }
}
