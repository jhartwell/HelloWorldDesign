using System;
using System.Reflection;
using System.Linq;
using HelloWorld.DependencyInjection;
using HelloWorld.Common;
using HelloWorld.Common.Interfaces;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using HelloWorld.CommandLine.DependencyInjection;
namespace HelloWorld.CommandLine
{
    class Program
    {
    
        static void Main(string[] args)
        {
            var commandLineApplication = new CommandLineApplication(new ServiceCollection());
            var provider = commandLineApplication.Build();
            var service = provider.GetRequiredService<IService<string>>();
            Console.WriteLine(service.Fetch());
        }
    }
}
