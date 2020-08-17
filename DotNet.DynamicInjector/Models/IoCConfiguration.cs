using System.Collections.Generic;
using System.Linq;

namespace DotNet.DynamicInjector.Models
{
    public class IoCConfiguration
    {
        public List<IoCRole> Roles { get; }
        public List<string> AllowedInterfaceNamespaces { get; }

        public IoCConfiguration()
        {
            Roles = new List<IoCRole>();
            AllowedInterfaceNamespaces = new List<string>();
        }

        public IoCConfiguration(List<IoCRole> roles, List<string> allowedInterfaceNamespaces) : this()
        {
            Roles = roles;
            AllowedInterfaceNamespaces = allowedInterfaceNamespaces;
        }

        public void AddRole(IoCRole role) =>
            Roles.Add(role);
        
        public void AddRoles(List<IoCRole> roles) =>
            Roles.AddRange(roles);

        public void AddAllowedInterfaceNamespace(string allowedInterfaceNamespace) =>
            AllowedInterfaceNamespaces.Add(allowedInterfaceNamespace);
        
        public void AddAllowedInterfaceNamespaces(List<string> allowedInterfaceNamespaces) =>
            AllowedInterfaceNamespaces.AddRange(allowedInterfaceNamespaces);

        public List<IoCRole> GetRolesByPriority()
        {
            return Roles?.Where(x => x.Active)
                     .OrderBy(x => x.Priority).ToList();
        }
    }
}
