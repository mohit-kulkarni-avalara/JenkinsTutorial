using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsTutorial.Startup))]
namespace JenkinsTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
