using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterOverideInMVC.Startup))]
namespace FilterOverideInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
