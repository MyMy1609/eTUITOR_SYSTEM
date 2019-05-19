using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;


namespace whiteboardEtutor.SignalRhub
{
    [HubName("whiteboardHub")]
    public class WhiteboardHub : Hub
    {
        public Task JoinGroup(string groupName)
        {
            return Groups.Add(Context.ConnectionId, groupName);
        }

        public async Task JoinGroups(IEnumerable<string> groups)
        {
            foreach(string groupName in groups)
            {
                await Groups.Add(Context.ConnectionId, groupName);
            }
        }

        public void SendDraw(string drawObject, string sessionId, string groupName, int width, int height)
        {
            Clients.Group(groupName).HandleDraw(drawObject, sessionId, width, height);
        }
    }
}