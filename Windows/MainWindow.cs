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
    public partial class MainWindow : Form
    {
        TicketManager ticketManager;

        public MainWindow()
        {
            InitializeComponent();
            ticketManager = new TicketManager(panel_Tickets, panel_TicketView);
            ticketManager.ioManager.loadScratchPad(scratchPad);
        }

        /*
         * The event for when the create ticket button is clicked
         */
        private void btn_CreateTicket_Click(object sender, EventArgs e)
        {
            if (box_Companies.SelectedItem == null) { return; }
            ticketManager.createTicket(box_Companies.SelectedItem.ToString());
        }

        /*
         * Exit application and give the all good code of 0
         */
        private void menu_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*
         * Starts the explorer and opens up the folder location for OTiS files
         */
        private void menu_OpenHistoryFolder_Click(object sender, EventArgs e)
        {
            Process.Start(ticketManager.ioManager.savePath);
        }

        /*
         * Navigates to the bug report tool
         */
        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://benburge.typeform.com/to/LRhvAG");
        }

        /*
         * Goes to the feature request tool
         */
        private void featureRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://benburge.typeform.com/to/H7fBK0");
        }

        /*
         * Opens the about box
         */
        private void menu_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog();
        }

        /*
         * Saves the scratch pad when it loses focus
         */
        private void scratchPad_Leave(object sender, EventArgs e)
        {
            ticketManager.ioManager.saveScratchPad(scratchPad);
        }

        /*
         * Saves the scratch pad when the window is closed
         */
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ticketManager.ioManager.saveScratchPad(scratchPad);
        }

        /*
         * Saves the scratch pad when the save button is clicked.
         */
        private void btn_Save_Click(object sender, EventArgs e)
        {
            ticketManager.ioManager.saveScratchPad(scratchPad);
        }
    }
}
