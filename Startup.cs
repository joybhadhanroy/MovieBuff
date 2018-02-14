using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieBuff.Startup))]
namespace MovieBuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
