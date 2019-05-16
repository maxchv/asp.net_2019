using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson13.Startup))]
namespace lesson13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
