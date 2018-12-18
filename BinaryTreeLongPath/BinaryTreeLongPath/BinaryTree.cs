using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeLongPath
{
    internal class BinaryTree
    {
        private readonly LinkedList<LinkedList<int>> _tree = new LinkedList<LinkedList<int>>();

        public BinaryTree(LinkedList<LinkedList<int>> tree)
        {
            Tree = tree;
        }

        public LinkedList<LinkedList<int>> Tree { get; }

        public void AddLineBottom(LinkedList<int> line)
        {
            _tree.AddLast(line);
        }

        public void AddLineTop(LinkedList<int> line)
        {
            _tree.AddFirst(line);
        }
    }
}
