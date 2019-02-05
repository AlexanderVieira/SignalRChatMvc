using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChatMvc.Models
{
    public class ChatHub:Hub
    {
        public void Send(string nickname, string message)
        {
            Clients.All.SendAsync(nickname, message);
        }
    }
}
