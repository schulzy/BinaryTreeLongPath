using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeLongPath.Interface;

namespace BinaryTreeLongPath.Creator
{
    class CalculatedBinaryTreeCreator : IBinaryTreeCreator
    {
        private BinaryTree _binaryTree = new BinaryTree();
        private BinaryTree _originalBinaryTree;

        public BinaryTree BinaryTree => _binaryTree;

        public CalculatedBinaryTreeCreator(BinaryTree originalBinaryTree)
        {
            _originalBinaryTree = originalBinaryTree;
        }

        public void CreateTree()
        {
            LinkedList<int> last = _originalBinaryTree.Tree.Last.Value;
            LinkedList<int> penultimate = null;

            for (LinkedListNode<LinkedList<int>> node = _originalBinaryTree.Tree.Last.Previous;
                node != null;
                node = node.Previous)
            {
                
                penultimate = node.Value;
                var newLine = new int[penultimate.Count];

                for (int i = 0; i < last.Count; i++)
                {
                    if (i > 0)
                    {
                        if (newLine[i - 1] < last.ElementAt(i) + penultimate.ElementAt(i - 1))
                            newLine[i - 1] = last.ElementAt(i) + penultimate.ElementAt(i - 1);
                    }

                    if (i < last.Count - 1)
                    {
                        newLine[i] = last.ElementAt(i) + penultimate.ElementAt(i);
                    }
                }

                last = new LinkedList<int>(newLine);
                _binaryTree.AddLineTop(last);
            }
        }
    }
}
