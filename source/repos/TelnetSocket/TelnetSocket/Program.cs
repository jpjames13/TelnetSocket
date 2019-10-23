using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TelnetSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Test Print";

            string telnetServerIp = "172.16.139.169";
            //string telnetServerIp = "172.16.3.16";
            int telnetPort = 9100;
            //int telnetPort = 80;

            TcpClient client = new TcpClient(telnetServerIp, telnetPort);

            // Translate the passed message into ASCII and store it as a Byte array.
            byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            //Get a client stream for reading and writing.
            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            client.Close();
        }
    }
}
