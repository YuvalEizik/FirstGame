using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace FirstGame
{
    class Server
    {       

        public static int MaxPlayers { get; private set; }
        public static int Port { get; private set; }

        private static TcpListener tcpListener;

        public void Start(int maxPlayers, int _port)
        {
            MaxPlayers = maxPlayers;
            Port = _port;

            tcpListener = new TcpListener(IPAddress.Any, Port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback,null);

            Console.WriteLine($"Server started on {Port},");
        }
    }
}
