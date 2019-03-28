using System;
namespace HelloWorld.Common.Interfaces
{
    /// <summary>
    /// Generic interface that handles pulling data from a given source.
    /// Additional methods can be added if needing different data
    /// from a single source
    /// </summary>
    public interface IRepository<T>
    {
        T Get();
    }
}
