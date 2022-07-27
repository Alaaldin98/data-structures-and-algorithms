//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;
//using data_structures_and_algorithms;
//using data_structures_and_algorithms.stack_queue_brackets;

//namespace Balanced
//{
//    public class TestBalanced
//    {
       

//        [Fact]
//        public void Testbalance()
//        {
//            BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
//            bool Result = stack_Queue_Brackets.validatebrackets("{}");
//        Assert.True(Result);
//        }
//        [Fact]
//        public void Testbalance1()
//        {
//            BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
//            bool Result = stack_Queue_Brackets.validatebrackets("{}(){}");
//            Assert.True(Result);
//        }
//        [Fact]
//        public void Testbalance2()
//        {
//            BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
//            bool Result = stack_Queue_Brackets.validatebrackets("[({}]");
//            Assert.False(Result);
//        }

//    }
//}
