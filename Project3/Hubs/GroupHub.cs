using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Project3.Server;
using System.Collections;

namespace Project3.Hubs
{
	public class GroupHub : Hub
	{
		public async Task CreateNewGroup()
		{
			Server.Server.IncreaseCount();
			await Clients.All.SendAsync("createGroup");
		}

		public async Task FindGroupLength()
		{
			await Clients.All.SendAsync("setGroupLength", Server.Server.GetGroupCount());
		}
	}
}
