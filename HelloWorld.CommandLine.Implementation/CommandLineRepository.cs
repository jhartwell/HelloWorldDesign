using System;
using HelloWorld.Common.Interfaces;

namespace HelloWorld.CommandLine.Implementation
{
    /// <summary>
    /// Concrete implementation of <see cref="IRepository{T}"/> for the
    /// Command Line project where T is a string
    /// </summary>
    public class CommandLineRepository : IRepository<string>
    {
        public string Get()
        {
            return "Hello World";
        }
    }
}
