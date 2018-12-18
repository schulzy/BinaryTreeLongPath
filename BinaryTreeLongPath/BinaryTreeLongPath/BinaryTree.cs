using System.Collections.Generic;

namespace BinaryTreeLongPath
{
    public class BinaryTree
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
