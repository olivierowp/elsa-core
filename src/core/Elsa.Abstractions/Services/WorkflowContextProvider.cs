﻿using System;
using System.Collections.Generic;

namespace Elsa.Services
{
    public abstract class WorkflowContextProvider : IWorkflowContextProvider
    {
        public abstract IEnumerable<Type> SupportedTypes { get; }
    }
    
    public abstract class WorkflowContextProvider<T> : WorkflowContextProvider
    {
        public override IEnumerable<Type> SupportedTypes => new[] { typeof(T) };
    }
}