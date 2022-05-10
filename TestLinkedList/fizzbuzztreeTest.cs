using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using data_structures_and_algorithms;

using static data_structures_and_algorithms.FizzBuzzTree.FNode;
using data_structures_and_algorithms.FizzBuzzTree;

namespace TestFizzBuzzTree
{
    public class fizzbuzztreeTest
    {
        [Fact]
        public void Test1()
        {
            FNode FirstFNode = new FNode(100);
            K_Ary_Tree MyTree = new K_Ary_Tree(FirstFNode);

            FNode child1 = new FNode(2);
            FNode child2 = new FNode(1);
            MyTree.Root.AddBranch(child1);
            MyTree.Root.AddBranch(child2);
            FNode child3 = new FNode(4);
            FNode child4 = new FNode(20);

            child1.AddBranch(child3);
            child1.AddBranch(child4);
            FNode child5 = new FNode(3);
            child2.AddBranch(child5);
            FNode child6 = new FNode(17);
            FNode child7 = new FNode(15);
            child5.AddBranch(child6);
            child5.AddBranch(child7);
            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTree(MyTree);
            List<string> MyExpected = new List<string>() { "Buzz", "2", "1", "4", "Buzz", "Fizz", "17", "FizzBuzz" };
            Assert.Equal(MyList, MyExpected);
        }
    }
}
