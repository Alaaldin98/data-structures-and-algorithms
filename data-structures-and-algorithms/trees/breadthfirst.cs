//using System.Collections.Generic;

//namespace data_structures_and_algorithms.trees
//{
//    public class breadthfirst
//    {
//        public List<tree> breadthFirst(tree root)
//        {

//            Queue breadth = new Queue();
//            breadth.Enqueue(root);

//            while (!breadth.IsEmpty)
//            {
//                Node front = (Node)breadth.Dequeue();


//                if (front.left is not null)
//                    breadth.Enqueue(front.left);

//                if (front.right is not null)
//                    breadth.Enqueue(front.right);
//            }
//            return breadth;
//        } 

//    }
//}
