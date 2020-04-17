using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Project3.Server;
using System.Collections;

namespace Project3.Hubs
{
	public class GroupHub : Hub
	{
		public async Task SendGroups(string content)
		{
			await Clients.All.SendAsync("RecieveGroups", Server.Server.ManageGroups(content));
		}

		public async Task AttemptMethod(ArrayList messages)
		{
			await Clients.All.SendAsync("writeToPage", messages);
		}
	}
}
