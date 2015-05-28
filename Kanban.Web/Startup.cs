using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kanban.Web.Startup))]
namespace Kanban.Web
{
		public partial class Startup
		{
				public void Configuration(IAppBuilder app)
				{
					app.MapSignalR();
						ConfigureAuth(app);
				}
		}
}
