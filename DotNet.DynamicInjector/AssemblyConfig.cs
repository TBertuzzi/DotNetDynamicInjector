using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace DotNet.DynamicInjector
{
    public class AssemblyConfig
    {
        public static Assembly LoadAssembly(string dll)
        {
            var location = Assembly.GetEntryAssembly().Location;
            var directoryName = Path.GetDirectoryName(location);

            var file = new FileInfo(Path.Combine(directoryName, dll));

            if (!file.Exists)
                throw new DynamicInjectorException($"Dll {dll} not found in folder {directoryName}.");

            return AssemblyLoadContext.Default.LoadFromAssemblyPath(file.FullName);
        }
    }
}
