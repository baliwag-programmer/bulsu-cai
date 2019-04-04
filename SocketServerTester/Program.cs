using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SockerServer.Classes;
namespace SocketServerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Listener.StartListening();
        }
    }
}
