using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

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
                throw new Exception($"Dll {dll} not found in folder {directoryName}.");

            return AssemblyLoadContext.Default.LoadFromAssemblyPath(file.FullName);
        }
    }
}
