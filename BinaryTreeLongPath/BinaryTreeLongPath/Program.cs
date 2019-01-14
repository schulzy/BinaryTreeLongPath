using System;
using BinaryTreeLongPath.Modul;
using Unity;

namespace BinaryTreeLongPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            var register = new Registration();
            register.RegisterPrepare(container);

            var pathFinder = new PathFinderManager(container);
            Console.WriteLine(pathFinder.GetPathSum());
            Console.ReadLine();
        }
    }
}
