using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Project3.Server;

namespace Project3.Hubs
{
	public class GroupHub : Hub
	{
		public async Task SendGroups(string content)
		{
			await Clients.All.SendAsync("RecieveGroups", Server.Server.ManageGroups(content));
		}
	}
}
