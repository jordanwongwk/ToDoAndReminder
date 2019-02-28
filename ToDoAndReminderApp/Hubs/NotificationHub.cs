using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ToDoAndReminderApp.Hubs
{
    public class NotificationHub : Hub
    {
        public string Activate()
        {
            return "Monitor Activated";
        }
    }
}
