/*
 *  **NOTE**
 *  
 *  PLEASE USE THIS AS A TEMPLATE FOR MAKING NEW TICKETS
 *  
 *  I am going to comment this out but not all the other tickets since they are all the same with a few
 *  changes here and there
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTiS
{
    public partial class Company : Form
    {
        //This is the reference to the ticket manager
        TicketManager ticketManager;

        /*
         *  This is the default constructor for the ticket
         *  you need to pass in a reference to the ticket manager
         */
        public Company(TicketManager parentManager)
        {
            InitializeComponent();
            ticketManager = parentManager;
        }

        /*
         * This is the click event to hide the ticket when the hide button is pressed
         */
        private void hide_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        /*
         * What to do when the close button is clicked
         */
        private void close_Click(object sender, EventArgs e)
        {
            ticketManager.closeTicket(this);
        }

        /*
         * What to do when we click the copyall
         */
        private void btn_CopyAll_Click(object sender, EventArgs e)
        {
            ticketManager.copyTicket(this);
        }

        /*
         * Copy notes click event
         */
        private void copyNotes_Click(object sender, EventArgs e)
        {
            ticketManager.copyField(notes.Text);
        }

        /*
         * Copy resolution click event
         */
        private void copyResolution_Click(object sender, EventArgs e)
        {
            ticketManager.copyField(resolution.Text);
        }

        /*
         * Copy description click event
         */
        private void copyDescription_Click(object sender, EventArgs e)
        {
            ticketManager.copyField(problem.Text);
        }
    }
}
