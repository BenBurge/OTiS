using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTiS
{
    //Allows this to show up in the toolbox
    [ToolboxItem(true)]
    class TicketButton : Button
    {
        //Gets the ticket
        public Form ticket { get; }

        /*
         * This is the default construtor for TicketButton 
         * Requires:
         * A ticket
         */
        public TicketButton(Form newTicket)
        {
            ticket = newTicket;
        }

        /*
         * This is called when the button is clicked and will show or hide the ticket.
         * 
         */
        public void showOrHideTicket()
        {
            if (ticket.Visible == false)
                ticket.Visible = true;
            else
                ticket.Visible = false;
        }
    }
}
