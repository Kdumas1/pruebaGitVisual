using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(presetacion.Startup))]
namespace presetacion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
