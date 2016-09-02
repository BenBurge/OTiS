using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTiS
{
    public class TicketManager
    {
        public FlowLayoutPanel ticketHolder;
        public Panel ticketView;
        public IOManager ioManager;

        public TicketManager(FlowLayoutPanel ticketPanel, Panel openTicketView)
        {
            ticketHolder = ticketPanel;
            ticketView = openTicketView;
            ioManager = new IOManager();
        }

        /*
         * Creates a new ticket and a button for that ticket
         * It then adds the button to the view so they can select it
         */
        public void createTicket(string companyName)
        {
            //Check for blank or null values
            if (companyName != null && companyName.Equals("")) { return; }

            //Create ticket form
            Form newTicket = createTicketForm(companyName);
            newTicket.TopLevel = false;
            newTicket.AutoScroll = false;
            newTicket.FormBorderStyle = FormBorderStyle.None;
            ticketView.Controls.Add(newTicket);

            //Create ticket button
            TicketButton newButton = new TicketButton(newTicket);
            newButton.Click += new EventHandler(ticketButton_Click);
            newButton.Text = companyName;
            newButton.Width = 125;
            ticketHolder.Controls.Add(newButton);

            //Add button and show form
            clearTicketView();
            newTicket.Show();
        }

        /*
         * Saves the ticket data and removes it
         */
        public void closeTicket(Form ticket)
        {
            //Save ticket
            saveTicket(ticket);

            //Remove Ticket Butotn
            removeTicketButton(ticket);

            //Remove Tikcet
            ticket.Visible = false;
            ticket.Dispose();
        }

        /*
         * Copys the ticket information to the clipboard
         */
        public void copyTicket(Form ticket)
        {
            if (ticket == null) { return; }
            string data = ioManager.copyAll(ticket);
            Console.WriteLine(data);
            try
            {
                Clipboard.SetText(data);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("An issue has occured");
                Console.Error.WriteLine(e.ToString());
            }
        }

        /*
         * Copys specific fields to the clip board
         */
        public void copyField(string fieldData)
        {
            if (fieldData == null) { return; }
            Clipboard.SetText(fieldData);
        }

        /*
         * Clears all the tickets from the view
         */
        public void clearTicketView()
        {
            //Go through each ticket
            foreach(Control control in ticketView.Controls)
            {
                //If it is a valid ticket
                if(control is Form)
                {
                    //Hide it
                    control.Visible = false;
                }
            }
        }

        /*
         * Create the appropriate ticket based on the options in the dropdown menu
         */
        private Form createTicketForm(string companyName)
        {
            switch (companyName)
            {
                case "Company":
                    return new Company(this);
            }

            //If we found not ticket for the company selected return the ERROR ticket
            return new ERROR(this);
        }

        /*
         * Calls the button method to show or hide the ticket
         */
        private void ticketButton_Click(object sender, EventArgs e)
        {
            TicketButton tb = sender as TicketButton;
            clearTicketView();
            tb.showOrHideTicket();
        }

        /*
         * Find the button that goes with the ticket and remove it from the list
         */
        private void removeTicketButton(Form ticket)
        {
            //Go through each button in the list
            foreach(TicketButton button in ticketHolder.Controls)
            {
                //If this is the button for the ticket remove it
                if (button.ticket == ticket) { ticketHolder.Controls.Remove(button); }
            }
        }

        /*
         * This saves the ticket to the history file
         */
        private void saveTicket(Form ticket)
        {
            ioManager.writeData(ticket);
        }
    }
}
