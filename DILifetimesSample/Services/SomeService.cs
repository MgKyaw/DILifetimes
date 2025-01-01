using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifetimesSample.Services
{
    public class SomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public SomeService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }

    public interface ITransientService
    {
        Guid GetGuid();
    }

    public interface IScopedService
    {
        Guid GetGuid();
    }

    public interface ISingletonService
    {
        Guid GetGuid();
    }
}