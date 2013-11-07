using Microsoft.AspNet.SignalR;

namespace Web
{
    public class EventHub : Hub
    {
        public void Join(string key, string username)
        {
            Groups.Add(Context.ConnectionId, key);
        }
    }
}
