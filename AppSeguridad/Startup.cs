using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppSeguridad.Startup))]
namespace AppSeguridad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
