using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC2Assignment1.Startup))]
namespace MVC2Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
