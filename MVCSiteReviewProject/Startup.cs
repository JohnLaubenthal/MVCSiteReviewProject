using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSiteReviewProject.Startup))]
namespace MVCSiteReviewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
