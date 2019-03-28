using System;
using Microsoft.Extensions.DependencyInjection;
using HelloWorld.Common.Interfaces;
using System.Collections.Generic;

namespace HelloWorld.DependencyInjection
{
    /// <summary>
    /// An abstract implementation of <see cref="IApplication"/>. It requires
    /// a <see cref="IServiceCollection"/> for the constructor but does not
    /// implement the required build steps.
    /// </summary>
    public abstract class AbstractApplication : IApplication
    {
        protected IServiceCollection serviceCollection;

        public AbstractApplication(IServiceCollection collection)
        {
            serviceCollection = collection;
        }

        public abstract IServiceProvider Build();
    }
}
