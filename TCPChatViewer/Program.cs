namespace TCPChatViewer
{
    public class Program
    {
        public static TcpChatViewer viewer;

        protected static void InterruptHandler(object sender, ConsoleCancelEventArgs args)
        {
            viewer.Disconnect();
            args.Cancel = true;
        }

        public static void Main(string[] args)
        {
            // Setup the Viewer
            string host = "localhost";//args[0].Trim();
            int port = 6000;//int.Parse(args[1].Trim());
            viewer = new TcpChatViewer(host, port);

            // Add a handler for a Ctrl-C press
            Console.CancelKeyPress += InterruptHandler;

            // Try to connect & view messages
            viewer.Connect();
            viewer.ListenForMessages();
        }
    }
}