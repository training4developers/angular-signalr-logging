using Microsoft.AspNet.SignalR;
using NLog;

namespace AngularSignalRLogging.Hubs
{
	public class LoggerHub : Hub
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		public void Info(string message)
		{
			Logger.Info(message);
		} 

		public void Error(string message)
		{
			Logger.Error(message);
		}
	}
}