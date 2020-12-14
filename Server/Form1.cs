using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            new Form2(int.Parse(port.Text)).Show();
            listen.Enabled = false;
        }

        private void port_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
