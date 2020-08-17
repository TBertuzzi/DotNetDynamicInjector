using System;

namespace DotNet.DynamicInjector
{
    public class DynamicInjectorException : Exception
    {
        public DynamicInjectorException() { }

        public DynamicInjectorException(string name)
            : base(name) { }
    }
}
