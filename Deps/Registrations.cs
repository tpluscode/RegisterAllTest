using System.Collections.Generic;
using Nancy;
using Nancy.Bootstrapper;

namespace Deps
{
    public class Registrations : Nancy.Bootstrapper.Registrations
    {
        public Registrations()
        {
            Register<IService>(typeof(Service));
            RegisterAll<IDep>(Lifetime.PerRequest);
        }
    }

    public class Module : NancyModule
    {
        public Module(IService ser)
        {
        }
    }

    public class Service : IService
    {
        public Service(IEnumerable<IDep> deps)
        {
        }
    }

    public interface IService
    {
    }

    public interface IDep
    {
    }
}
