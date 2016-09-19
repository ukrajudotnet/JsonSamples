using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsonTask.Startup))]
namespace JsonTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
