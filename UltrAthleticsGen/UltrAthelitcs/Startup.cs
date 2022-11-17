using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UltrAthelitcs.Startup))]
namespace UltrAthelitcs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
