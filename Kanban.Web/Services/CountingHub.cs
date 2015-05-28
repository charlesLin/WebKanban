using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Kanban.Web.Services
{
	public class CountingHub : Hub
	{
		public void Increase(int lineId)
		{
			Clients.All.increase(lineId);
		}
	}
}