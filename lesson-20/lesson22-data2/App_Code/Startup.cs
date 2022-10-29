using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson22_data2.Startup))]
namespace lesson22_data2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
