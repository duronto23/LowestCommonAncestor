using System.Collections.Generic;
using System.Linq;

namespace LowestCommonAncestor
{
    public class Tree
    {
        public List<int> Nodes { get; set; }
        public Node Root { get; set; }
        public string Lca(int node1, int node2)
        {
            if (Nodes.All(n => !n.Equals(node1)) || Nodes.All(n => !n.Equals(node2)))
                return "Nodes are not present in the tree.";
            return CalculateLca(Root, node1, node2).Data.ToString();
        }

        private static Node CalculateLca(Node root, int node1, int node2)
        {
            if (root == null)
            {
                return null;
            }            
            if (root.Data == node1 || root.Data == node2)
            {                
                return root;
            }            
            var leftLca = CalculateLca(root.Left, node1, node2);
            var rightLca = CalculateLca(root.Right, node1, node2);
           
            if (leftLca != null && rightLca != null)
            {
                return root;
            }
            return leftLca ?? rightLca;
        }        
    }
}
