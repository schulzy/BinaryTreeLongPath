using System.Collections.Generic;
using System.Linq;
using BinaryTreeLongPath.Creator;
using BinaryTreeLongPath.Interface;
using Unity;

namespace BinaryTreeLongPath
{
    internal class PathFinderManager : IPathFinderManager
    {
        private readonly CalculatedBinaryTreeCreator _calculatedTreeCreator;

        public PathFinderManager(IUnityContainer container)
        {
            var binaryTreeCreator = container.Resolve<IBinaryTreeCreator>();
            binaryTreeCreator.CreateTree();

            _calculatedTreeCreator = new CalculatedBinaryTreeCreator(binaryTreeCreator.BinaryTree);
            _calculatedTreeCreator.CreateTree();
        }

        public int GetPathSum()
        {
            LinkedList<int> first = _calculatedTreeCreator.BinaryTree.Tree.FirstOrDefault();
            if (first != null) return first.FirstOrDefault();

            return 0;
        }
    }
}
