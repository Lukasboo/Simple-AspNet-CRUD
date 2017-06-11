using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspCRUDExample.Startup))]
namespace AspCRUDExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
