using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using NLog;

namespace AngularSignalRLogging
{
	public class Global : HttpApplication
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		private void Application_Start(object sender, EventArgs e)
		{
			// Code that runs on application startup
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			Logger.Info("signal4 application started");
		}
	}
}