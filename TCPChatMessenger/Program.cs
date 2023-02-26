namespace TCPChatMessenger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Get a name
            Console.Write("Enter a name to use: ");
            string name = Console.ReadLine();

            // Setup the Messenger
            string host = "localhost";//args[0].Trim();
            int port = 6000;//int.Parse(args[1].Trim());
            TcpChatMessenger messenger = new TcpChatMessenger(host, port, name);

            // connect and send messages
            messenger.Connect();
            messenger.SendMessages();
        }
    }
}