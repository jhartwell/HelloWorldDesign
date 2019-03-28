using System;
using HelloWorld.Common.Interfaces;

namespace HelloWorld.CommandLine.Tests.Mocks
{
    public class MockRepository : IRepository<string>
    {
        public string Get()
        {
            return "Test Data";
        }
    }
}
