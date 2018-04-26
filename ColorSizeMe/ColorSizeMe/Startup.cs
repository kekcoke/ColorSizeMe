using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColorSizeMe.Startup))]
namespace ColorSizeMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
