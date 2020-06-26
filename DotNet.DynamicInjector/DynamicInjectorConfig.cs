using DotNet.DynamicInjector.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DotNet.DynamicInjector
{
    public static class DynamicInjectorConfig
    {
        public static void RegisterDynamicDependencies(this IServiceCollection services, IoCConfiguration iocConfiguration)
        {
            try
            {
                foreach (var iocRole in iocConfiguration.Roles)
                {
                    var assembly = AssemblyConfig.LoadAssembly(iocRole.Dll);

                    var exportedTypes = assembly.ExportedTypes.Where(x => x.FullName
                                                .StartsWith(iocRole.Implementation, StringComparison.CurrentCulture)).ToList();

                    foreach (var exportedType in exportedTypes)
                    {
                        var allowedInterfaces = iocConfiguration.AllowedInterfaceNamespaces?.Count > 0 ? exportedType.GetInterfaces()
                            .Where(i => iocConfiguration.AllowedInterfaceNamespaces.Any(allowedNamespace => i.FullName.ToLower().StartsWith(allowedNamespace.ToLower()))) : exportedType.GetInterfaces();

                        foreach (var @interface in allowedInterfaces)
                        {
                            switch (iocRole.LifeTime.ToUpper())
                            {
                                case "SCOPED":
                                default:
                                    services.AddScoped(@interface, exportedType);
                                    break;
                                case "SINGLETON":
                                    services.AddSingleton(@interface, exportedType);
                                    break;
                                case "TRANSIENT":
                                    services.AddTransient(@interface, exportedType);
                                    break;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new DynamicInjectorException(ex.Message);
            }
        }
    }
}
