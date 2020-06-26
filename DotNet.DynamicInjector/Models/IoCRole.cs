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
        public string LifeTime { get; set; }
        public int Priority { get; set; }
        public bool Active { get; set; }
    }
}
