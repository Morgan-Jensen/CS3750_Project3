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
			await Clients.All.SendAsync("createGroup");
		}

		public async Task CreateNewItem()
		{
			await Clients.All.SendAsync("createItem");
		}
	}
}
