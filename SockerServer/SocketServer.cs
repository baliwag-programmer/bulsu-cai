using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SockerServer.Classes;

namespace SockerServer
{

    public partial class SocketServer : ServiceBase
    {
        public SocketServer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Listener.StartListening();
        }

        protected override void OnStop()
        {
        }
    }
}
