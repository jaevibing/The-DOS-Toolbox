using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_DOS_Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void slowloris_Click(object sender, EventArgs e)
        {
            this.Hide();
            var slowloris = new Slowloris();
            slowloris.Closed += (s, args) => this.Close();
            slowloris.Show();
        }

        private void UDP_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UDP = new UDP();
            UDP.Closed += (s, args) => this.Close();
            UDP.Show();
        }

        private void TCP_Click(object sender, EventArgs e)
        {
            this.Hide();
            var TCP = new TCP();
            TCP.Closed += (s, args) => this.Close();
            TCP.Show();
        }

        private void amplifiedudp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var audp = new AmplifiedUDP();
            audp.Closed += (s, args) => this.Close();
            audp.Show();
        }
    }
}
