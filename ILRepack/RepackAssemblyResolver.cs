using Mono.Cecil;
using System.Collections.Generic;

namespace ILRepacking
{
    public interface IRepackAssemblyResolver : IAssemblyResolver
    {
        void RegisterAssembly(AssemblyDefinition assembly);
    }

    public class RepackAssemblyResolver : DefaultAssemblyResolver, IRepackAssemblyResolver
    {
        public new void RegisterAssembly(AssemblyDefinition assembly)
        {
            base.RegisterAssembly(assembly);
        }
    }
}
