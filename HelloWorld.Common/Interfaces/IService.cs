using System;
namespace HelloWorld.Common.Interfaces
{
    /// <summary>
    /// A generic interface that is the basis for a service that drives the application
    /// </summary>
    public interface IService<T>
    {
        T Fetch();
    }
}
