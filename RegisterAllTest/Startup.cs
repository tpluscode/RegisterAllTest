using System;
using System.Collections.Generic;
using System.Linq;
using Deps;
using Microsoft.Owin;
using Nancy;
using Owin;
using RegisterAllTest;

[assembly: OwinStartup(typeof(Startup))]

namespace RegisterAllTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }

    public class TestModule : NancyModule
    {
        public TestModule(IEnumerable<IDep> allDeps)
        {
            Get[string.Empty] = _ =>
            {
                var array = allDeps.ToArray();
                return array.Length.ToString();
            };
        }
    }

    public class Dep1 : IDep { }
    public class Dep2 : IDep { }
    public class Dep3 : IDep { }
    public class Dep4 : IDep { }
}