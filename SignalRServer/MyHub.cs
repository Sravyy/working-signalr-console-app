using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRServer
{
    [HubName("MyHub")]
    public class MyHub : Hub
    {
        public string Send(string message)
        {
            Console.WriteLine("Recieved: " + message);
            return message;
        }

        public void DoSomething(string param)
        {
            Console.WriteLine("Recieved: " + param);
            Clients.All.addMessage(param);
        }
    }
}
