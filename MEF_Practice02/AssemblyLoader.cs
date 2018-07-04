using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace MEF_Practice02
{
    public class AssemblyLoader
    {
        private readonly ContainerConfiguration _container;

        public AssemblyLoader(string fileName)
        {
            var executableLocation = Assembly.GetEntryAssembly().Location;
            var path               = Path.Combine(Path.GetDirectoryName(executableLocation), "Plugins");

            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path + fileName + ".dll");
            _container = new ContainerConfiguration().WithAssembly(assembly);
        }

        public T Get<T>()
        {
            using (var container = _container.CreateContainer())
            {
                return container.GetExport<T>();
            }
        }
    }
}