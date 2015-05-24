using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetWFTest.Startup))]
namespace AspNetWFTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
