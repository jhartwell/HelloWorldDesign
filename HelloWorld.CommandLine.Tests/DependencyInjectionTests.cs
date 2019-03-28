using System;
using HelloWorld.CommandLine.DependencyInjection;
using HelloWorld.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace HelloWorld.CommandLine.Tests
{
    public class DependencyInjectionTests
    {
        [Fact]
        public void ContainerExists()
        {
            var application = new CommandLineApplication(new ServiceCollection());
            var provider = application.Build();
            Assert.NotNull(provider);
        }

        [Fact]
        public void ServicesProperlyWired()
        {
            var application = new CommandLineApplication(new ServiceCollection());
            var provider = application.Build();
            var service = provider.GetService<IService<string>>();
            Assert.NotNull(service);
        }
    }
}
