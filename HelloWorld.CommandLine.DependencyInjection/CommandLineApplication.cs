using System;
using HelloWorld.DependencyInjection;
using HelloWorld.Common.Interfaces;
using HelloWorld.CommandLine.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld.CommandLine.DependencyInjection
{
    /// <summary>
    /// Implementation of <see cref="AbstractApplication"/>. This class
    /// handles wiring up the dependencies for the CommandLine application
    /// </summary>
    public class CommandLineApplication : AbstractApplication
    {
        public CommandLineApplication(IServiceCollection collection) : base(collection)
        {
        }

        /// <summary>
        /// Building a <see cref="IServiceProvider"/> with the given
        /// concrete types for the required interfaces 
        /// </summary>
        /// <returns>An instance of <see cref="IServiceProvider"/> that contains
        /// the required mappings needed to run the application.</returns>
        public override IServiceProvider Build()
        {
            serviceCollection.AddScoped(typeof(IService<string>), typeof(CommandLineService));
            serviceCollection.AddScoped(typeof(IRepository<string>), typeof(CommandLineRepository));
            return serviceCollection.BuildServiceProvider();
        }

    }
}
