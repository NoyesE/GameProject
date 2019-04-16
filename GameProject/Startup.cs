using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameProject.Startup))]
namespace GameProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
