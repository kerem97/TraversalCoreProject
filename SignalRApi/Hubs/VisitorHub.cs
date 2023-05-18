using Microsoft.AspNetCore.SignalR;
using SignalRApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisiterService _visiterService;

        public VisitorHub(VisiterService visiterService)
        {
            _visiterService = visiterService;
        }

        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", _visiterService.GetVisitorChartList());
        }
    }
}
