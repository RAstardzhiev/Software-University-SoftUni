using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class TcpListenerStream
{
    private const int PortNumber = 1337;

    static void Main()
    {
        var tcpListener = new TcpListener(IPAddress.Any, PortNumber);

        tcpListener.Start();
        Console.WriteLine("Listening on port {0}...", PortNumber);

        while (true)
        {
            using (NetworkStream stream = tcpListener.AcceptTcpClient().GetStream())
            {
                byte[] request = new byte[4096];
                int readBytes = stream.Read(request, 0, 4096);
                Console.WriteLine(Encoding.UTF8.GetString(request, 0, readBytes));

                string html = string.Format("{0}{1}{2}{3} - {4}{2}{1}{0}",
                    "<html>", "<body>", "<h1>", "Welcome to my awesome site!", DateTime.Now);
                byte[] htmlBytes = Encoding.UTF8.GetBytes(html);

                stream.Write(htmlBytes, 0, htmlBytes.Length);
            }
        }
    }
}
