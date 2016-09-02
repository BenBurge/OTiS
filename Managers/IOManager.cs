/*
 *     +---------------------------------How IO Manager read in a ticket---------------------------------+
 *     | This works by reading in each field on a ticket. When it finds a valid field to read it will:   |
 *     | * Read the name of the field (ex. user_Name). It uses that as the name for the output           |
 *     | *It read in the data in that fields. It then attachs that data to the field name and writes it  |
 *     |                                                                                                 |
 *     | Example:                                                                                        |
 *     | CoSC Ticket would have something like this                                                      |
 *     | A textbox called "contact_Name" with the data 123-456-7890                                      |
 *     | So the output would be Contact Number: 123-456-7890                                             |
 *     |                                                                                                 |
 *     | Or another example                                                                              |
 *     | CoSC has a textbox called "name" with the data Steve Testerman                                  |
 *     | So the output would be Name: Steve Testerman                                                    |
 *     |                                                                                                 |
 *     | So when creating a new ticket please make sure that each textbox has the name like:             |
 *     | field_Name or fieldname -> Field Name or Fieldname                                              |
 *     +-------------------------------------------------------------------------------------------------+
 *     
 *     +-------------------------------------How to organize output--------------------------------------+
 *     | This program read in fields in the tab order so this means:                                     |
 *     | If contact_Number has a tab number of 2                                                         |
 *     | and                                                                                             |
 *     | name has a tab number of 1                                                                      |
 *     | the output would be as follows                                                                  |
 *     | Name: Steve Testerman                                                                           |
 *     | Contact Number: 123-456-7890                                                                    |
 *     +-------------------------------------------------------------------------------------------------+
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTiS
{
    public class IOManager
    {
        //Save path getter and setter
        public string savePath { get; set; }

        private string date;
        private string historyFile;
        private string scratchFile;
        private const char nameDelimter = '_';

        /*
         * This is the default constructor for IOManager
         */
        public IOManager()
        {
            //Get the todays date in MM-dd-yyyy format
            date = DateTime.Today.ToString("MM-dd-yyyy");
            
            //Setup OTiS save location for all files
            savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\OTIS Files\";
            //Sets the file name for history and scratchpad
            historyFile = savePath + date.ToString() + "_History.txt";
            scratchFile = savePath + "1-ScratchPad.txt";

            //Check for files and folders
            fileCheck();
            scratchPadFileCheck();
        }

        /*
         *  Writes the data from the ticket out to the history file.
         */
        public void writeData(Form ticket)
        {
            //Check for the appropriate files
            fileCheck();

            //Setup a list to store the data as we read it in.
            ArrayList data;
            //Setup a place to store the data to write it out after formating
            String formatedData;

            //Read in all the fields from the ticket.
            readInControls(ticket, out data);
            if (data.Count > 0)
            {
                //Format the data we have read in
                formatedData = formatOutputData(data);
            }
            else
            {
                //If there is not data then just exit this method.
                return;
            }
            //Being trying to write out the data
            try
            {
                using (StreamWriter writer = File.AppendText(historyFile))
                {
                    //Write the time we closed the ticket
                    writer.WriteLine("[" + DateTime.Now.ToString("hh:mm tt") + "]");
                    //Write the data out to the file
                    writer.WriteLine(formatedData);
                }

            }
            catch(IOException e)
            {
                //If this is an error write out to the console
                Console.WriteLine(e.ToString());
            }

        }

        /*
         * This copies all the fields from the ticket
         */
        public string copyAll(Form ticket)
        {
            ArrayList data;
            readInControls(ticket, out data);

            //If there is no information then just return blank.
            if (data.Count <= 0 || data == null) { return ""; }

            if (data.Count > 0)
            {
                //Return the data formated
                return formatOutputData(data);
            }
            else
            {
                //If there is nothing just return nothing.
                return "";
            }
        }

        /*
         *  Save the data on the scratchpad to the scratch file.
         */
        public void saveScratchPad(TextBox scratchPadBox)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(scratchFile))
                {
                    //Get the data from the scratchpad
                    string data = scratchPadBox.Text;
                    //Write the data to the file
                    writer.WriteLine(data);
                    //Clear out an data on the line and close it so it saves properly
                    writer.Flush();
                    writer.Close();
                }

            }
            catch (Exception e)
            {
                //If this is an error write out to the console
                Console.WriteLine(e.ToString());
            }
        }

        /*
         * Loads the data from scratch file to scratchpad
         */
        public void loadScratchPad(TextBox scratchPadBox)
        {
            try
            {
                using (StreamReader reader = new StreamReader(scratchFile))
                {
                    string nextLine;
                    //Read each line until we find it has no more lines
                    while ((nextLine = reader.ReadLine()) != null)
                    {
                        //Write the line to the scratchpad
                        scratchPadBox.AppendText(nextLine + "\n");
                    }
                }

            }
            catch (IOException e)
            {
                //If this is an error write out to the console
                Console.WriteLine(e.ToString());
            }
        }

        /*
         * Formats the data from the ticket to look good
         */
        private string formatOutputData(ArrayList data)
        {
            //Start a stringbuilder so we can add all the data nicely
            StringBuilder formatedOutput = new StringBuilder();
            string[] fieldName;

            //Loop trhough each field and read it's data
            foreach(Control control in data)
            {
                //Read the field name and split it where every we find an underscore (_)
                fieldName = control.Name.ToString().Split(nameDelimter);
                string fieldText = ": " + control.Text;

                StringBuilder sb = new StringBuilder();
                foreach(string word in fieldName)
                {
                    //Piece together the field data and upper case each world in the fieldname 
                    sb.Append(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ");
                }

                formatedOutput.AppendLine(sb.ToString().Remove(sb.ToString().Length - 1) + fieldText);
            }
            return formatedOutput.ToString() + "\n";
        }

        /*
         * Filters only the allowed fields so that we don't copy button (ex. Copy All)
         */
        private void readInControls(Form ticket, out ArrayList data)
        {
            data = new ArrayList();
            //Read in each field in order by tab index
            foreach(Control control in ticket.Controls.Cast<Control>().OrderBy(control => control.TabIndex))
            {
                //If the control is not a button or a label, or the field isn't blank then....
                if(!(control is Button) && !(control is Label) && !(control.Text.Equals("")))
                {
                    //Add the field to be used in saving or copy data
                    data.Add(control);
                }
            }
        }

        /*
         * Check to make sure we have the right folders and files created to save our data
         */
        private bool fileCheck()
        {
            historyFileDateCheck();

            //Does directory exist?
            if (!Directory.Exists(savePath))
            {
                //Create both the directory and file
                Directory.CreateDirectory(savePath);
                File.Create(historyFile).Close();
                File.Create(scratchFile).Close();
                return true;
            }
            //Dir exists but does todays file exist?
            else if (!File.Exists(historyFile))
            {
                //Create file
                File.Create(historyFile).Close();
                System.Console.WriteLine("File created - History File");
                return true;
            }
            return false;
        }

        /*
         * Checks for the history file
         */
        private void historyFileDateCheck()
        {
            if (!date.Equals(DateTime.Today.ToString("MM-dd-yyyy")) || File.Exists(savePath) == false)
            {
                date = DateTime.Today.ToString("MM-dd-yyyy");
                historyFile = savePath + date.ToString() + "_History.txt";
            }
        }

        /*
         * Check for the scratch pad file
         */
        private void scratchPadFileCheck()
        {
            if (!File.Exists(scratchFile))
            {
                File.Create(scratchFile).Close();
                System.Console.WriteLine("File created - Scratchpad File");
            }
        }
    }
}
