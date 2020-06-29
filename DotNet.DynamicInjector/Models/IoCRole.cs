using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.DynamicInjector.Models
{
    public class IoCRole
    {
        public string Name { get; set; }
        public string Dll { get; set; }
        public string Implementation { get; set; }
        public LifeTime LifeTime { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; }
    }
}
