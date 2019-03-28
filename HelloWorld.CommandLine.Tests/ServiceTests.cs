using System;
using HelloWorld.CommandLine.Implementation;
using HelloWorld.CommandLine.Tests.Mocks;
using Xunit;

namespace HelloWorld.CommandLine.Tests
{
    public class ServiceTests
    {
        [Fact]
        public void TestConcreteService()
        {
            var service = new CommandLineService(new MockRepository());
            Assert.Equal(Constants.TestText, service.Fetch());
        }

    }
}
