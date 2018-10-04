using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bez_log_form.Startup))]
namespace bez_log_form
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
