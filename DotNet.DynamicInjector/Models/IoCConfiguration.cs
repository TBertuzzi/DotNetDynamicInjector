using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.DynamicInjector.Models
{
    public class IoCConfiguration
    {
        private List<IoCRole> roles;
        public List<IoCRole> Roles 
        {   get
            {
                return roles?.Where(x => x.Active)
                    .OrderBy(x => x.Priority).ToList();
            }
            set
            {
                roles = value;
            }
        }

        public List<string> AllowedInterfaceNamespaces { get; set; }
    }
}
