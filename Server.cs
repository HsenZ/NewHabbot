using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientServerApp
{
    public class Server
    {
        private TcpListener listener;
        private int port = 8888; // Change this to your desired port number

        public Server()
        {
            listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                byte[] data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesRead);

                // Handle the received message as needed
                // Example:
                // Console.WriteLine("Received: " + message);

                client.Close();
            }
        }

        public void Stop()
        {
            listener.Stop();
        }
    }
}
