using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTiS
{
    public partial class ERROR : Form
    {
        TicketManager ticketManager;

        public ERROR(TicketManager parentManager)
        {
            InitializeComponent();
            ticketManager = parentManager;
        }

        private void close_Click(object sender, EventArgs e)
        {
            ticketManager.closeTicket(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://benburge.typeform.com/to/LRhvAG");
        }
    }
}
