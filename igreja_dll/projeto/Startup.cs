using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projeto.Startup))]
namespace projeto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
