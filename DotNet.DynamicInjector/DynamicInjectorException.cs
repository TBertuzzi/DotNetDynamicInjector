﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.DynamicInjector
{
    class DynamicInjectorException : Exception
    {
        public DynamicInjectorException()
        {

        }

        public DynamicInjectorException(string name)
            : base(name)
        {

        }
    }
}
