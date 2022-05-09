using System.Collections.Generic;
using static data_structures_and_algorithms.trees.tree;

namespace data_structures_and_algorithms.trees
{
    public class breadthfirst
    {
        public List<tree> breadthFirst(tree root)
        {

            queue breadth =  new queue();
            breadth.enqueue(root);

  while (!breadth.isempty)
            {
                node front = breadth.dequeue();


    if (front.left is not null)
                    breadth.enqueue(front.left);

    if (front.right is not null)
                    breadth.enqueue(front.right);
                        }
}

    }
}
