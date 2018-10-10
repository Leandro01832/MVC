using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_gerenciadordeconteudo.Startup))]
namespace MVC_gerenciadordeconteudo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
