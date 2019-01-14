using System.Collections.Generic;

namespace BinaryTreeLongPath.Interface
{
    public interface IBinaryTree
    {
        LinkedList<LinkedList<int>> Tree { get; }
        void AddLineBottom(LinkedList<int> line);
        void AddLineTop(LinkedList<int> line);
    }
}
