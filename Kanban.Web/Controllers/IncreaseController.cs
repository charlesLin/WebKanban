using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Kanban.Web.Services;
using Microsoft.AspNet.SignalR;

namespace Kanban.Web.Controllers
{
	public class IncreaseController : ApiController
	{
		public void Post(int lineId)
		{
			var hub = GlobalHost.ConnectionManager.GetHubContext<CountingHub>();
			hub.Clients.All.increase(lineId);
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}