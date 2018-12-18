using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeLongPath.Interface;
using Unity;

namespace BinaryTreeLongPath
{
    internal class PathFinderManager : IPathFinderManager
    {
        public PathFinderManager(IUnityContainer container)
        {
            var binaryTreeCreator = container.Resolve<IBinaryTreeCreator>();
            binaryTreeCreator.CreateTree();
        }

        public int GetPathSum()
        {
            return 0;
        }
    }
}
