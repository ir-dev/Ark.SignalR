using Microsoft.AspNetCore.SignalR;

namespace Ark.SignalR
{
    public class ArkSignalHub : Hub
    {
        public virtual async Task InvokeEventAsync(string evt, string content)
        {
            await Clients.All.SendAsync(evt, content);
        }
    }
}