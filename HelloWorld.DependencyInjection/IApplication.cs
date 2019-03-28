using System;
namespace HelloWorld.DependencyInjection
{
    /// <summary>
    /// Interface that is basis of the dependency injection
    /// </summary>
    public interface IApplication
    {
        IServiceProvider Build();
    }
}
