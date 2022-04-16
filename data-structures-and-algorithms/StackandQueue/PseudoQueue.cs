//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace data_structures_and_algorithms
//{
//    public class PseudoQueue
//    {
//		public Stack stack1 = new Stack();
//		public Stack stack2 = new Stack();
		
//		public void Enqueue(int x)
//		{
//			// Move all elements from stack1 to stack2
//			while (stack1.length > 0)
//				stack2.push(stack1.pop());

//			// Push item into stack1

//			stack1.push(x);

//			// Push everything back to stack1
//			while (stack2.length > 0)
//				stack1.push(stack2.pop());
//		}

//		public void Dequeue()
//		{
//			if (stack1.length == 0)
//				Console.WriteLine("is Empty");

//			stack1.pop();
//		}

//		public Object Peek()
//		{
//			return stack1.peek();
//		}
//	}
//}
