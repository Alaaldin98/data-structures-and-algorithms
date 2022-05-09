using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.trees
{
    public class treemax
    {
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
}
