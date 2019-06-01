using System.Collections.Generic;
using LowestCommonAncestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LowestCommonAncestorTests
{
    [TestClass()]
    public class LcaTests
    {
        [TestMethod()]
        public void LcaTest()
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

            Assert.AreEqual("3", tree.Lca(6, 7));
            Assert.AreEqual("3", tree.Lca(3, 7));
            Assert.AreEqual("1", tree.Lca(8, 7));
            Assert.AreEqual("2", tree.Lca(8, 5));
        }

        [TestMethod()]
        public void NodeNotExistsTest()
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

            Assert.AreEqual("Nodes are not present in the tree.", tree.Lca(15, 7));
            Assert.AreEqual("Nodes are not present in the tree.", tree.Lca(6, 10));
            Assert.AreEqual("Nodes are not present in the tree.", tree.Lca(12, 13));
        }
    }
}