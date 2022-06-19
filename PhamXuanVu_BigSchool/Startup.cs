using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamXuanVu_BigSchool.Startup))]
namespace PhamXuanVu_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
