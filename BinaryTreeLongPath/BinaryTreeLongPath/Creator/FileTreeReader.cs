using System.Collections.Generic;
using System.Runtime.InteropServices;
using BinaryTreeLongPath.Interface;

namespace BinaryTreeLongPath.Creator
{
    class FileTreeReader : ITreeReader
    {
        private string _path;

        public FileTreeReader(string path)
        {
            _path = path;
        }

        public LinkedList<string> Lines { get; } = new LinkedList<string>();

        public void Read()
        {
            string[] lines = System.IO.File.ReadAllLines(_path);
        }
    }
}
