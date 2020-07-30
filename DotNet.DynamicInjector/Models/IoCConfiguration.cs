using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.DynamicInjector.Models
{
    public class IoCConfiguration
    {
        public List<IoCRole> Roles {get;}
        public List<string> AllowedInterfaceNamespaces { get; set; }

        public IoCConfiguration()
        {
            Roles = new List<IoCRole> ();
        }

        public List<IoCRole> GetRolesByPriority()
        {
            return Roles?.Where(x => x.Active)
                     .OrderBy(x => x.Priority).ToList();
        }
    }
}
