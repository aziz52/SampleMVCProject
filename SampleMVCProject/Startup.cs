using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleMVCProject.Startup))]
namespace SampleMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
