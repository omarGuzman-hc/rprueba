using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Didactico.Startup))]
namespace Didactico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
