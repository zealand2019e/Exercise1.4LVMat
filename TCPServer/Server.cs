using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NewAssignment;
using Newtonsoft.Json;

namespace TCPServer

{
    class Server
    {
        static List<Book> books = new List<Book>()
        {
            new Book("1984", "George Orwell", 243, "3215423215429"),
            new Book("Twenty Thousand Leagues Under the Sea", "Jules Verne", 151, "9215483218428"),
            new Book("Small Prince", "A. d. Saint-Exupéry", 300, "9997448539997"),
            new Book("Metro 2033", "D. Glukhovsky", 530,  "5544483218433"),
            new Book("Brave New World ", " A. Huxley", 330,  "5544483218433")
        };

        public void Start()
        {
            int clientNmr = 0;
            TcpListener server = null;
           
                IPAddress localAddr = IPAddress.Loopback;
                int port = 4646;


                server = new TcpListener(localAddr, port);

                server.Start();

                while (true)
                {
                    Console.Write("Waiting for a connection... ");

             
                    TcpClient client = server.AcceptTcpClient();

                    Console.WriteLine("Connected!");

                    Task.Run(() => Stream(client, ref clientNmr));
                }
          
        }

        public void Stream(TcpClient client, ref int clientNmr)
        {
            //
        }

    }
}