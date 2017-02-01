using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRResearch.SignalRLib
{
    public class TestHub : Hub
    {
        public void AddEncounterGroup(string pageKey)
        {
            this.Groups.Add(this.Context.ConnectionId, pageKey);
        }

        public void SendGroupMessage(string pageKey)
        {
            Clients.Group(pageKey).closeChild();
        }
    }
}
