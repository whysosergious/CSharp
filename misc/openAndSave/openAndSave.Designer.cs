namespace openAndSave {
		partial class OpenAndSave {
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
						this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
						this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
						this.menuStrip1 = new System.Windows.Forms.MenuStrip();
						this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiNew = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiOpen = new System.Windows.Forms.ToolStripMenuItem();
						this.tmiSave = new System.Windows.Forms.ToolStripMenuItem();
						this.panel1 = new System.Windows.Forms.Panel();
						this.tbxDocument = new System.Windows.Forms.TextBox();
						this.menuStrip1.SuspendLayout();
						this.panel1.SuspendLayout();
						this.SuspendLayout();
						// 
						// dlgOpenFile
						// 
						this.dlgOpenFile.FileName = "File1";
						this.dlgOpenFile.Filter = "Text Files|*.txt|CSV Files|*.csv|All Files|*.*";
						this.dlgOpenFile.InitialDirectory = "D:\\work\\csharp\\csharp\\openAndSave\\files";
						// 
						// dlgSaveFile
						// 
						this.dlgSaveFile.FileName = "File1";
						this.dlgSaveFile.Filter = "Text Files|*.txt|CSV Files|*.csv|All Files|*.*";
						this.dlgSaveFile.InitialDirectory = "D:\\work\\csharp\\csharp\\openAndSave\\files";
						// 
						// menuStrip1
						// 
						this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
						this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
						this.menuStrip1.Location = new System.Drawing.Point(0, 0);
						this.menuStrip1.Name = "menuStrip1";
						this.menuStrip1.Size = new System.Drawing.Size(800, 28);
						this.menuStrip1.TabIndex = 0;
						this.menuStrip1.Text = "menuStrip1";
						// 
						// fileToolStripMenuItem
						// 
						this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNew,
            this.tmiOpen,
            this.tmiSave});
						this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
						this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
						this.fileToolStripMenuItem.Text = "File";
						// 
						// tmiNew
						// 
						this.tmiNew.Name = "tmiNew";
						this.tmiNew.Size = new System.Drawing.Size(224, 26);
						this.tmiNew.Text = "New";
						this.tmiNew.Click += new System.EventHandler(this.tmiNew_Click);
						// 
						// tmiOpen
						// 
						this.tmiOpen.Name = "tmiOpen";
						this.tmiOpen.Size = new System.Drawing.Size(224, 26);
						this.tmiOpen.Text = "Open";
						this.tmiOpen.Click += new System.EventHandler(this.tmiOpen_Click);
						// 
						// tmiSave
						// 
						this.tmiSave.Name = "tmiSave";
						this.tmiSave.Size = new System.Drawing.Size(224, 26);
						this.tmiSave.Text = "Save";
						this.tmiSave.Click += new System.EventHandler(this.tmiSave_Click);
						// 
						// panel1
						// 
						this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.panel1.Controls.Add(this.tbxDocument);
						this.panel1.Location = new System.Drawing.Point(12, 31);
						this.panel1.Name = "panel1";
						this.panel1.Size = new System.Drawing.Size(776, 407);
						this.panel1.TabIndex = 2;
						// 
						// tbxDocument
						// 
						this.tbxDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.tbxDocument.Location = new System.Drawing.Point(18, 14);
						this.tbxDocument.Multiline = true;
						this.tbxDocument.Name = "tbxDocument";
						this.tbxDocument.Size = new System.Drawing.Size(736, 380);
						this.tbxDocument.TabIndex = 2;
						// 
						// OpenAndSave
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.panel1);
						this.Controls.Add(this.menuStrip1);
						this.MainMenuStrip = this.menuStrip1;
						this.Name = "OpenAndSave";
						this.Text = "File1";
						this.menuStrip1.ResumeLayout(false);
						this.menuStrip1.PerformLayout();
						this.panel1.ResumeLayout(false);
						this.panel1.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.SaveFileDialog dlgSaveFile;
				private System.Windows.Forms.MenuStrip menuStrip1;
				private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem tmiOpen;
				private System.Windows.Forms.ToolStripMenuItem tmiSave;
				private System.Windows.Forms.Panel panel1;
				private System.Windows.Forms.TextBox tbxDocument;
				private System.Windows.Forms.ToolStripMenuItem tmiNew;
		}
}

