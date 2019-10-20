using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server serv = new Server();
            serv.Start();
        }
    }
    
}
