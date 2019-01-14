using System.Collections.Generic;
using BinaryTreeLongPath.Interface;

namespace BinaryTreeLongPath
{
    public class BinaryTree : IBinaryTree
    {
        public LinkedList<LinkedList<int>> Tree { get; } = new LinkedList<LinkedList<int>>();

        public void AddLineBottom(LinkedList<int> line)
        {
            Tree.AddLast(line);
        }

        public void AddLineTop(LinkedList<int> line)
        {
            Tree.AddFirst(line);
        }
    }

    
}
