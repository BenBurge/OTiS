namespace OTiS
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenHistoryFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ticket_Tab = new System.Windows.Forms.TabPage();
            this.panel_Tickets = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Companies = new System.Windows.Forms.Panel();
            this.btn_CreateTicket = new System.Windows.Forms.Button();
            this.box_Companies = new System.Windows.Forms.ComboBox();
            this.panel_TicketView = new System.Windows.Forms.Panel();
            this.scratchPad_Tab = new System.Windows.Forms.TabPage();
            this.scratchPad = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ticket_Tab.SuspendLayout();
            this.panel_Companies.SuspendLayout();
            this.scratchPad_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_OpenHistoryFolder,
            this.menu_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_OpenHistoryFolder
            // 
            this.menu_OpenHistoryFolder.Name = "menu_OpenHistoryFolder";
            this.menu_OpenHistoryFolder.Size = new System.Drawing.Size(180, 22);
            this.menu_OpenHistoryFolder.Text = "Open History Folder";
            this.menu_OpenHistoryFolder.Click += new System.EventHandler(this.menu_OpenHistoryFolder_Click);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(180, 22);
            this.menu_Exit.Text = "Exit";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_About,
            this.reportABugToolStripMenuItem,
            this.featureRequestToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(158, 22);
            this.menu_About.Text = "About";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // featureRequestToolStripMenuItem
            // 
            this.featureRequestToolStripMenuItem.Name = "featureRequestToolStripMenuItem";
            this.featureRequestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.featureRequestToolStripMenuItem.Text = "Feature Request";
            this.featureRequestToolStripMenuItem.Click += new System.EventHandler(this.featureRequestToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.ticket_Tab);
            this.tabControl1.Controls.Add(this.scratchPad_Tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 447);
            this.tabControl1.TabIndex = 5;
            // 
            // ticket_Tab
            // 
            this.ticket_Tab.BackColor = System.Drawing.SystemColors.Control;
            this.ticket_Tab.Controls.Add(this.panel_Tickets);
            this.ticket_Tab.Controls.Add(this.panel_Companies);
            this.ticket_Tab.Controls.Add(this.panel_TicketView);
            this.ticket_Tab.Location = new System.Drawing.Point(4, 25);
            this.ticket_Tab.Name = "ticket_Tab";
            this.ticket_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_Tab.Size = new System.Drawing.Size(712, 418);
            this.ticket_Tab.TabIndex = 0;
            this.ticket_Tab.Text = "Ticket";
            // 
            // panel_Tickets
            // 
            this.panel_Tickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Tickets.Location = new System.Drawing.Point(6, 70);
            this.panel_Tickets.Name = "panel_Tickets";
            this.panel_Tickets.Size = new System.Drawing.Size(133, 342);
            this.panel_Tickets.TabIndex = 6;
            // 
            // panel_Companies
            // 
            this.panel_Companies.Controls.Add(this.btn_CreateTicket);
            this.panel_Companies.Controls.Add(this.box_Companies);
            this.panel_Companies.Location = new System.Drawing.Point(6, 6);
            this.panel_Companies.Name = "panel_Companies";
            this.panel_Companies.Size = new System.Drawing.Size(133, 58);
            this.panel_Companies.TabIndex = 5;
            // 
            // btn_CreateTicket
            // 
            this.btn_CreateTicket.Location = new System.Drawing.Point(3, 30);
            this.btn_CreateTicket.Name = "btn_CreateTicket";
            this.btn_CreateTicket.Size = new System.Drawing.Size(127, 23);
            this.btn_CreateTicket.TabIndex = 1;
            this.btn_CreateTicket.Text = "Create Ticket";
            this.btn_CreateTicket.UseVisualStyleBackColor = true;
            this.btn_CreateTicket.Click += new System.EventHandler(this.btn_CreateTicket_Click);
            // 
            // box_Companies
            // 
            this.box_Companies.FormattingEnabled = true;
            this.box_Companies.Items.AddRange(new object[] {
            "Company"});
            this.box_Companies.Location = new System.Drawing.Point(3, 3);
            this.box_Companies.Name = "box_Companies";
            this.box_Companies.Size = new System.Drawing.Size(127, 21);
            this.box_Companies.Sorted = true;
            this.box_Companies.TabIndex = 0;
            this.box_Companies.SelectedValueChanged += new System.EventHandler(this.btn_CreateTicket_Click);
            // 
            // panel_TicketView
            // 
            this.panel_TicketView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_TicketView.Location = new System.Drawing.Point(145, 6);
            this.panel_TicketView.Name = "panel_TicketView";
            this.panel_TicketView.Size = new System.Drawing.Size(564, 419);
            this.panel_TicketView.TabIndex = 0;
            // 
            // scratchPad_Tab
            // 
            this.scratchPad_Tab.Controls.Add(this.scratchPad);
            this.scratchPad_Tab.Controls.Add(this.btn_Save);
            this.scratchPad_Tab.Location = new System.Drawing.Point(4, 25);
            this.scratchPad_Tab.Name = "scratchPad_Tab";
            this.scratchPad_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.scratchPad_Tab.Size = new System.Drawing.Size(712, 418);
            this.scratchPad_Tab.TabIndex = 1;
            this.scratchPad_Tab.Text = "Scratch Pad";
            this.scratchPad_Tab.UseVisualStyleBackColor = true;
            // 
            // scratchPad
            // 
            this.scratchPad.Location = new System.Drawing.Point(6, 3);
            this.scratchPad.Multiline = true;
            this.scratchPad.Name = "scratchPad";
            this.scratchPad.Size = new System.Drawing.Size(700, 387);
            this.scratchPad.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(6, 392);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(700, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OTiS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ticket_Tab.ResumeLayout(false);
            this.panel_Companies.ResumeLayout(false);
            this.scratchPad_Tab.ResumeLayout(false);
            this.scratchPad_Tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenHistoryFolder;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureRequestToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ticket_Tab;
        private System.Windows.Forms.TabPage scratchPad_Tab;
        private System.Windows.Forms.Panel panel_TicketView;
        private System.Windows.Forms.FlowLayoutPanel panel_Tickets;
        private System.Windows.Forms.Panel panel_Companies;
        private System.Windows.Forms.Button btn_CreateTicket;
        private System.Windows.Forms.ComboBox box_Companies;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox scratchPad;
    }
}

