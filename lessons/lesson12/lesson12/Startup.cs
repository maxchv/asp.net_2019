using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson12.Startup))]
namespace lesson12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
