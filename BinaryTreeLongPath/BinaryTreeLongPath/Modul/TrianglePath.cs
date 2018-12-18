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
            return Path.Combine(Constants.Constant.TREE_PATH, codeBase);
        }
    }
}