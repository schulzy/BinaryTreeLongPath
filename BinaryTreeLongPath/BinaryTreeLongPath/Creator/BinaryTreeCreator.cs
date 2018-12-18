using System.Collections.Generic;
using BinaryTreeLongPath.Interface;

namespace BinaryTreeLongPath.Creator
{
    internal class BinaryTreeCreator : IBinaryTreeCreator
    {
        private ITreeReader _reader;
        private BinaryTree _binaryTree = new BinaryTree();

        public BinaryTreeCreator(ITreeReader reader)
        {
            _reader = reader;
        }

        public BinaryTree BinaryTree => _binaryTree;

        public void CreateTree()
        {
            _reader.Read();
            var lines = _reader.Lines;

            foreach (string line in lines)
            {
                _binaryTree.AddLineBottom(CreateList(line));
            }
        }

        private LinkedList<int> CreateList(string line)
        {
            var list = new LinkedList<int>();
            string[] numbers = line.Split(' ');
            foreach (string number in numbers)
            {
                list.AddLast(int.Parse(number));
            }

            return list;
        }
    }
}
