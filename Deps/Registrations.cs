using System.Collections.Generic;
using Nancy;
using Nancy.Bootstrapper;

namespace Deps
{
    public class Registrations : Nancy.Bootstrapper.Registrations
    {
        public Registrations()
        {
            RegisterAll<IDep>(Lifetime.PerRequest);
        }
    }

    public interface IDep
    {
    }
}
