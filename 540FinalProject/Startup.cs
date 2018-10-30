using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_540FinalProject.Startup))]
namespace _540FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
