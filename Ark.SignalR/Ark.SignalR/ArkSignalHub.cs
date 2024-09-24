using Microsoft.AspNetCore.SignalR;

namespace Ark.SignalR
{
    public class ArkSignalHub : Hub
    {
        public virtual async Task InvokeEventAsync(string evt, string content)
        {
            if (Clients == null) return; //TODO: validate if missing any?
            await Clients.All.SendAsync(evt, content);
        }
    }
}