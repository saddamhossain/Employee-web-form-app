using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeWebApp.Startup))]
namespace EmployeeWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
