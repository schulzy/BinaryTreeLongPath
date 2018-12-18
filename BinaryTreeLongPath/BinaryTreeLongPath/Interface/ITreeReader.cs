using System.Collections.Generic;

namespace BinaryTreeLongPath.Interface
{
    public interface ITreeReader
    {
        LinkedList<string> Lines { get; }
        void Read();
    }
}
