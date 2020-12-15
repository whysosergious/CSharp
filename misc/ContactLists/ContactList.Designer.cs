namespace ContactLists {
		partial class ContactList {
				/// <summary>
				/// Required designer variable.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Clean up any resources being used.
				/// </summary>
				/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				protected override void Dispose(bool disposing) {
						if (disposing && (components != null)) {
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form Designer generated code

				/// <summary>
				/// Required method for Designer support - do not modify
				/// the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent() {
						this.tmiFile = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiNewFile = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiSaveFile = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiExitApp = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiEdit = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiNewContact = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
						this.mspMain = new System.Windows.Forms.MenuStrip();
						this.lbxContacts = new System.Windows.Forms.ListBox();
						this.label5 = new System.Windows.Forms.Label();
						this.panel2 = new System.Windows.Forms.Panel();
						this.btnDeleteContact = new System.Windows.Forms.Button();
						this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
						this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
						this.panel1 = new System.Windows.Forms.Panel();
						this.label7 = new System.Windows.Forms.Label();
						this.tbxComment = new System.Windows.Forms.TextBox();
						this.tbxPhoneNr = new System.Windows.Forms.TextBox();
						this.btnSaveContact = new System.Windows.Forms.Button();
						this.tbxEmail = new System.Windows.Forms.TextBox();
						this.tbxLastName = new System.Windows.Forms.TextBox();
						this.tbxFirstName = new System.Windows.Forms.TextBox();
						this.label6 = new System.Windows.Forms.Label();
						this.label4 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label1 = new System.Windows.Forms.Label();
						this.mspMain.SuspendLayout();
						this.panel2.SuspendLayout();
						this.panel1.SuspendLayout();
						this.SuspendLayout();
						// 
						// tmiFile
						// 
						this.tmiFile.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNewFile,
            this.tmiOpenFile,
            this.tmiSaveFile,
            this.tmiSaveFileAs,
            this.tmiExitApp});
						this.tmiFile.ForeColor = System.Drawing.Color.Turquoise;
						this.tmiFile.Name = "tmiFile";
						this.tmiFile.Size = new System.Drawing.Size(46, 24);
						this.tmiFile.Text = "File";
						// 
						// tmiNewFile
						// 
						this.tmiNewFile.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiNewFile.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiNewFile.Name = "tmiNewFile";
						this.tmiNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
						this.tmiNewFile.Size = new System.Drawing.Size(233, 26);
						this.tmiNewFile.Text = "New";
						this.tmiNewFile.Click += new System.EventHandler(this.tmiNewFile_Click);
						// 
						// tmiOpenFile
						// 
						this.tmiOpenFile.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiOpenFile.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiOpenFile.Name = "tmiOpenFile";
						this.tmiOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
						this.tmiOpenFile.Size = new System.Drawing.Size(233, 26);
						this.tmiOpenFile.Text = "Open";
						this.tmiOpenFile.Click += new System.EventHandler(this.tmiOpenFile_Click);
						// 
						// tmiSaveFile
						// 
						this.tmiSaveFile.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiSaveFile.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiSaveFile.Name = "tmiSaveFile";
						this.tmiSaveFile.ShortcutKeyDisplayString = "";
						this.tmiSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
						this.tmiSaveFile.Size = new System.Drawing.Size(233, 26);
						this.tmiSaveFile.Text = "Save";
						this.tmiSaveFile.Click += new System.EventHandler(this.tmiSaveFile_Click);
						// 
						// tmiSaveFileAs
						// 
						this.tmiSaveFileAs.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiSaveFileAs.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiSaveFileAs.Name = "tmiSaveFileAs";
						this.tmiSaveFileAs.Padding = new System.Windows.Forms.Padding(0, 1, 0, 4);
						this.tmiSaveFileAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
						this.tmiSaveFileAs.Size = new System.Drawing.Size(233, 29);
						this.tmiSaveFileAs.Text = "Save As";
						this.tmiSaveFileAs.Click += new System.EventHandler(this.tmiSaveFileAs_Click);
						// 
						// tmiExitApp
						// 
						this.tmiExitApp.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiExitApp.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiExitApp.Name = "tmiExitApp";
						this.tmiExitApp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
						this.tmiExitApp.Size = new System.Drawing.Size(233, 26);
						this.tmiExitApp.Text = "Exit";
						this.tmiExitApp.Click += new System.EventHandler(this.tmiExitApp_Click);
						// 
						// tmiEdit
						// 
						this.tmiEdit.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNewContact,
            this.tmiDeleteContact});
						this.tmiEdit.ForeColor = System.Drawing.Color.Turquoise;
						this.tmiEdit.Name = "tmiEdit";
						this.tmiEdit.Size = new System.Drawing.Size(49, 24);
						this.tmiEdit.Text = "Edit";
						// 
						// tmiNewContact
						// 
						this.tmiNewContact.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiNewContact.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiNewContact.Name = "tmiNewContact";
						this.tmiNewContact.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
						this.tmiNewContact.Size = new System.Drawing.Size(230, 26);
						this.tmiNewContact.Text = "New Contact";
						this.tmiNewContact.Click += new System.EventHandler(this.tmiNewContact_Click);
						// 
						// tmiDeleteContact
						// 
						this.tmiDeleteContact.BackColor = System.Drawing.Color.DarkSlateGray;
						this.tmiDeleteContact.ForeColor = System.Drawing.SystemColors.Window;
						this.tmiDeleteContact.Name = "tmiDeleteContact";
						this.tmiDeleteContact.ShortcutKeys = System.Windows.Forms.Keys.Delete;
						this.tmiDeleteContact.Size = new System.Drawing.Size(230, 26);
						this.tmiDeleteContact.Text = "Delete Contact";
						this.tmiDeleteContact.Click += new System.EventHandler(this.tmiDeleteContact_Click);
						// 
						// mspMain
						// 
						this.mspMain.BackColor = System.Drawing.Color.DarkSlateGray;
						this.mspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
						this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiFile,
            this.tmiEdit});
						this.mspMain.Location = new System.Drawing.Point(0, 0);
						this.mspMain.Name = "mspMain";
						this.mspMain.Size = new System.Drawing.Size(632, 28);
						this.mspMain.TabIndex = 8;
						this.mspMain.Text = "menuStrip1";
						// 
						// lbxContacts
						// 
						this.lbxContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
						this.lbxContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.lbxContacts.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.lbxContacts.FormattingEnabled = true;
						this.lbxContacts.ItemHeight = 20;
						this.lbxContacts.Location = new System.Drawing.Point(15, 41);
						this.lbxContacts.Name = "lbxContacts";
						this.lbxContacts.Size = new System.Drawing.Size(208, 320);
						this.lbxContacts.TabIndex = 8;
						this.lbxContacts.SelectedIndexChanged += new System.EventHandler(this.lbxContacts_SelectedIndexChanged);
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
						this.label5.Location = new System.Drawing.Point(15, 3);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(128, 29);
						this.label5.TabIndex = 15;
						this.label5.Text = "Saved Contacts";
						this.label5.UseCompatibleTextRendering = true;
						// 
						// panel2
						// 
						this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.panel2.Controls.Add(this.btnDeleteContact);
						this.panel2.Controls.Add(this.label5);
						this.panel2.Controls.Add(this.lbxContacts);
						this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.panel2.Location = new System.Drawing.Point(377, 57);
						this.panel2.MaximumSize = new System.Drawing.Size(300, 640);
						this.panel2.MinimumSize = new System.Drawing.Size(204, 322);
						this.panel2.Name = "panel2";
						this.panel2.Size = new System.Drawing.Size(243, 434);
						this.panel2.TabIndex = 10;
						// 
						// btnDeleteContact
						// 
						this.btnDeleteContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.btnDeleteContact.BackColor = System.Drawing.Color.DarkMagenta;
						this.btnDeleteContact.FlatAppearance.BorderSize = 0;
						this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.btnDeleteContact.ForeColor = System.Drawing.SystemColors.Window;
						this.btnDeleteContact.Location = new System.Drawing.Point(15, 366);
						this.btnDeleteContact.Name = "btnDeleteContact";
						this.btnDeleteContact.Size = new System.Drawing.Size(208, 41);
						this.btnDeleteContact.TabIndex = 16;
						this.btnDeleteContact.Text = "Delete";
						this.btnDeleteContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.btnDeleteContact.UseVisualStyleBackColor = false;
						this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
						// 
						// dlgOpenFile
						// 
						this.dlgOpenFile.FileName = "Select File";
						this.dlgOpenFile.Filter = "CSV Files|*.csv|All Files|*.*";
						// 
						// dlgSaveFile
						// 
						this.dlgSaveFile.FileName = "Untitled";
						this.dlgSaveFile.Filter = "CSV Files|*.csv";
						// 
						// panel1
						// 
						this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.panel1.Controls.Add(this.label7);
						this.panel1.Controls.Add(this.tbxComment);
						this.panel1.Controls.Add(this.tbxPhoneNr);
						this.panel1.Controls.Add(this.btnSaveContact);
						this.panel1.Controls.Add(this.tbxEmail);
						this.panel1.Controls.Add(this.tbxLastName);
						this.panel1.Controls.Add(this.tbxFirstName);
						this.panel1.Controls.Add(this.label6);
						this.panel1.Controls.Add(this.label4);
						this.panel1.Controls.Add(this.label3);
						this.panel1.Controls.Add(this.label2);
						this.panel1.Controls.Add(this.label1);
						this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.panel1.Location = new System.Drawing.Point(12, 57);
						this.panel1.MaximumSize = new System.Drawing.Size(450, 410);
						this.panel1.MinimumSize = new System.Drawing.Size(300, 350);
						this.panel1.Name = "panel1";
						this.panel1.Size = new System.Drawing.Size(360, 380);
						this.panel1.TabIndex = 11;
						// 
						// label7
						// 
						this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
						this.label7.AutoSize = true;
						this.label7.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
						this.label7.Location = new System.Drawing.Point(99, 11);
						this.label7.Name = "label7";
						this.label7.Size = new System.Drawing.Size(166, 29);
						this.label7.TabIndex = 17;
						this.label7.Text = "Contact Information";
						this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
						this.label7.UseCompatibleTextRendering = true;
						// 
						// tbxComment
						// 
						this.tbxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.tbxComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.tbxComment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.tbxComment.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.tbxComment.Location = new System.Drawing.Point(128, 236);
						this.tbxComment.MinimumSize = new System.Drawing.Size(4, 43);
						this.tbxComment.Multiline = true;
						this.tbxComment.Name = "tbxComment";
						this.tbxComment.Size = new System.Drawing.Size(226, 73);
						this.tbxComment.TabIndex = 51;
						// 
						// tbxPhoneNr
						// 
						this.tbxPhoneNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.tbxPhoneNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.tbxPhoneNr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.tbxPhoneNr.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.tbxPhoneNr.Location = new System.Drawing.Point(128, 191);
						this.tbxPhoneNr.Name = "tbxPhoneNr";
						this.tbxPhoneNr.Size = new System.Drawing.Size(226, 23);
						this.tbxPhoneNr.TabIndex = 50;
						// 
						// btnSaveContact
						// 
						this.btnSaveContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
						this.btnSaveContact.BackColor = System.Drawing.Color.DarkMagenta;
						this.btnSaveContact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
						this.btnSaveContact.FlatAppearance.BorderSize = 0;
						this.btnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnSaveContact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.btnSaveContact.ForeColor = System.Drawing.SystemColors.Window;
						this.btnSaveContact.Location = new System.Drawing.Point(185, 334);
						this.btnSaveContact.Name = "btnSaveContact";
						this.btnSaveContact.Size = new System.Drawing.Size(169, 41);
						this.btnSaveContact.TabIndex = 41;
						this.btnSaveContact.Text = "Create New";
						this.btnSaveContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.btnSaveContact.UseVisualStyleBackColor = false;
						this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
						// 
						// tbxEmail
						// 
						this.tbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.tbxEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.tbxEmail.Location = new System.Drawing.Point(128, 146);
						this.tbxEmail.Name = "tbxEmail";
						this.tbxEmail.Size = new System.Drawing.Size(226, 23);
						this.tbxEmail.TabIndex = 49;
						// 
						// tbxLastName
						// 
						this.tbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.tbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.tbxLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.tbxLastName.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.tbxLastName.Location = new System.Drawing.Point(128, 101);
						this.tbxLastName.Name = "tbxLastName";
						this.tbxLastName.Size = new System.Drawing.Size(226, 23);
						this.tbxLastName.TabIndex = 48;
						// 
						// tbxFirstName
						// 
						this.tbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.tbxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.tbxFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.tbxFirstName.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.tbxFirstName.Location = new System.Drawing.Point(128, 56);
						this.tbxFirstName.Name = "tbxFirstName";
						this.tbxFirstName.Size = new System.Drawing.Size(226, 23);
						this.tbxFirstName.TabIndex = 47;
						// 
						// label6
						// 
						this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.label6.AutoSize = true;
						this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.label6.Location = new System.Drawing.Point(10, 237);
						this.label6.Name = "label6";
						this.label6.Size = new System.Drawing.Size(79, 21);
						this.label6.TabIndex = 46;
						this.label6.Text = "Comment";
						// 
						// label4
						// 
						this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.label4.AutoSize = true;
						this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.label4.Location = new System.Drawing.Point(10, 192);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(76, 21);
						this.label4.TabIndex = 45;
						this.label4.Text = "Phone Nr";
						// 
						// label3
						// 
						this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.label3.Location = new System.Drawing.Point(10, 147);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(48, 21);
						this.label3.TabIndex = 44;
						this.label3.Text = "Email";
						// 
						// label2
						// 
						this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.label2.Location = new System.Drawing.Point(10, 102);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(84, 21);
						this.label2.TabIndex = 43;
						this.label2.Text = "Last Name";
						// 
						// label1
						// 
						this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
						this.label1.Location = new System.Drawing.Point(10, 57);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(97, 21);
						this.label1.TabIndex = 42;
						this.label1.Text = "First Name *";
						// 
						// ContactList
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.SystemColors.ControlLight;
						this.ClientSize = new System.Drawing.Size(632, 503);
						this.Controls.Add(this.panel1);
						this.Controls.Add(this.panel2);
						this.Controls.Add(this.mspMain);
						this.MaximumSize = new System.Drawing.Size(740, 700);
						this.MinimumSize = new System.Drawing.Size(610, 480);
						this.Name = "ContactList";
						this.RightToLeft = System.Windows.Forms.RightToLeft.No;
						this.Text = "Untitled Contact List";
						this.mspMain.ResumeLayout(false);
						this.mspMain.PerformLayout();
						this.panel2.ResumeLayout(false);
						this.panel2.PerformLayout();
						this.panel1.ResumeLayout(false);
						this.panel1.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.ToolStripMenuItem tmiFile;
				private System.Windows.Forms.ToolStripMenuItem tmiNewFile;
				private System.Windows.Forms.ToolStripMenuItem tmiOpenFile;
				private System.Windows.Forms.ToolStripMenuItem tmiSaveFile;
				private System.Windows.Forms.ToolStripMenuItem tmiSaveFileAs;
				private System.Windows.Forms.ToolStripMenuItem tmiExitApp;
				private System.Windows.Forms.ToolStripMenuItem tmiEdit;
				private System.Windows.Forms.ToolStripMenuItem tmiNewContact;
				private System.Windows.Forms.ToolStripMenuItem tmiDeleteContact;
				private System.Windows.Forms.MenuStrip mspMain;
				private System.Windows.Forms.ListBox lbxContacts;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.Panel panel2;
				private System.Windows.Forms.Button btnDeleteContact;
				private System.Windows.Forms.OpenFileDialog dlgOpenFile;
				private System.Windows.Forms.SaveFileDialog dlgSaveFile;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbxComment;
		private System.Windows.Forms.TextBox tbxPhoneNr;
		private System.Windows.Forms.TextBox tbxEmail;
		private System.Windows.Forms.TextBox tbxLastName;
		private System.Windows.Forms.TextBox tbxFirstName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSaveContact;
		private System.Windows.Forms.Label label7;
	}
}

