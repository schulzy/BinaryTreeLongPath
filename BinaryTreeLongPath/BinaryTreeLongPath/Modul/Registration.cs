using BinaryTreeLongPath.Creator;
using BinaryTreeLongPath.Interface;
using Unity;
using Unity.Injection;

namespace BinaryTreeLongPath.Modul
{
    internal class Registration
    {
        public void RegisterPrepare(IUnityContainer container)
        {
            container.RegisterType<ITreeReader, FileTreeReader>(new InjectionConstructor(new TrianglePath().GetPath()));
            container.RegisterType<IBinaryTreeCreator, BinaryTreeCreator>();
        }
    }
}
