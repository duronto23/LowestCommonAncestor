using System;
using System.Collections.Generic;

namespace LowestCommonAncestor
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var tree = new Tree
            {
                Nodes = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9},
                Root = new Node(1)
                {
                    Left = new Node(2),
                    Right = new Node(3)
                }
            };
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);
            tree.Root.Left.Left.Left = new Node(8);
            tree.Root.Left.Left.Right = new Node(9);
            
            Console.WriteLine("LCA(4, 5) = " + tree.Lca(6, 7));
            Console.WriteLine("LCA(4, 5) = " + tree.Lca(3, 7));
            Console.WriteLine("LCA(4, 10) = " + tree.Lca(4, 10));
            Console.Read();
        }
    }
}
