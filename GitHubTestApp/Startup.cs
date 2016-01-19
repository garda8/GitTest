using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTestApp.Startup))]
namespace GitHubTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
