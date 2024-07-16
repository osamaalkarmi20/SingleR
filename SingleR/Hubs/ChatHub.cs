using Microsoft.AspNetCore.SignalR;

namespace SingleR.Hubs
{
	public class ChatHub: Hub
	{
		public async Task SendMessage(string user, string message) 
		{
		
		await Clients.All.SendAsync("Recived Messages", user, message);
		}
	}
}
