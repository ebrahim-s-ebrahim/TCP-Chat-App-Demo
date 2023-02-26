using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPChatServer
{
    class Program
    {
        public static TcpChatServer chat;

        protected static void InterruptHandler(object sender, ConsoleCancelEventArgs args)
        {
            chat.Shutdown();
            args.Cancel = true;
        }

        public static void Main(string[] args)
        {
            // Create the server
            string name = "Bad IRC";//args[0].Trim();
            int port = 6000;//int.Parse(args[1].Trim());
            chat = new TcpChatServer(name, port);

            // Add a handler for a Ctrl-C press
            Console.CancelKeyPress += InterruptHandler;

            // run the chat server
            chat.Run();
        }
    }
}