using BinaryTreeLongPath.Interface;

namespace BinaryTreeLongPath.Creator
{
    internal class BinaryTreeCreator : IBinaryTreeCreator
    {
        private ITreeReader _reader;

        public BinaryTreeCreator(ITreeReader reader)
        {
            _reader = reader;
        }

        public void CreateTree()
        {
            
        }
    }
}
