using System;
using HelloWorld.Common.Interfaces;

namespace HelloWorld.CommandLine.Implementation
{

    /// <summary>
    /// Concrete implementation of <see cref="IService{T}"/> for
    /// the Command Line application
    /// </summary>
    public class CommandLineService : IService<string>
    {
        private IRepository<string> repository;
        public CommandLineService(IRepository<string> repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Pulls data from the repository
        /// </summary>
        /// <returns>A <see cref="string"/> that contains the returned
        /// data from the <see cref="IRepository{T}"/></returns>
        public string Fetch()
        {
            return repository.Get();
        }
    }
}
