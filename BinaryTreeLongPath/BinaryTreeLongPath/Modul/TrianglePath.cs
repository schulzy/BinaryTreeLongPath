using System;
using System.IO;
using System.Reflection;

namespace BinaryTreeLongPath.Modul
{
    internal class TrianglePath
    {
        public string GetPath()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            Uri path = new Uri(codeBase);
            return Path.Combine(Path.GetDirectoryName(path.AbsolutePath), Constants.Constant.TREE_PATH);
        }
    }
}