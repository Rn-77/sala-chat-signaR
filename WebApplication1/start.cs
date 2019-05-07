using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(salaChat.start))]
namespace salaChat
{
    public class start : Hub
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}