namespace Travel {
		partial class Travel {
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
						this.gbxSavedList = new System.Windows.Forms.GroupBox();
						this.panel2 = new System.Windows.Forms.Panel();
						this.btnShowOnMap = new System.Windows.Forms.Button();
						this.btnDelFromList = new System.Windows.Forms.Button();
						this.btnSearchInList = new System.Windows.Forms.Button();
						this.tbxSearchInList = new System.Windows.Forms.TextBox();
						this.lbxSavedList = new System.Windows.Forms.ListBox();
						this.panel1 = new System.Windows.Forms.Panel();
						this.btnSaveToList = new System.Windows.Forms.Button();
						this.mapsBrowser = new System.Windows.Forms.WebBrowser();
						this.gbxSavedList.SuspendLayout();
						this.panel2.SuspendLayout();
						this.panel1.SuspendLayout();
						this.SuspendLayout();
						// 
						// gbxSavedList
						// 
						this.gbxSavedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.gbxSavedList.Controls.Add(this.panel2);
						this.gbxSavedList.Controls.Add(this.btnSearchInList);
						this.gbxSavedList.Controls.Add(this.tbxSearchInList);
						this.gbxSavedList.Controls.Add(this.lbxSavedList);
						this.gbxSavedList.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.gbxSavedList.ForeColor = System.Drawing.SystemColors.WindowFrame;
						this.gbxSavedList.Location = new System.Drawing.Point(963, 12);
						this.gbxSavedList.MaximumSize = new System.Drawing.Size(300, 800);
						this.gbxSavedList.MinimumSize = new System.Drawing.Size(265, 0);
						this.gbxSavedList.Name = "gbxSavedList";
						this.gbxSavedList.Size = new System.Drawing.Size(265, 629);
						this.gbxSavedList.TabIndex = 27;
						this.gbxSavedList.TabStop = false;
						this.gbxSavedList.Text = "Saved Places";
						// 
						// panel2
						// 
						this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.panel2.Controls.Add(this.btnShowOnMap);
						this.panel2.Controls.Add(this.btnDelFromList);
						this.panel2.Location = new System.Drawing.Point(20, 558);
						this.panel2.Name = "panel2";
						this.panel2.Size = new System.Drawing.Size(229, 43);
						this.panel2.TabIndex = 32;
						// 
						// btnShowOnMap
						// 
						this.btnShowOnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
						this.btnShowOnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
						this.btnShowOnMap.Enabled = false;
						this.btnShowOnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnShowOnMap.ForeColor = System.Drawing.Color.White;
						this.btnShowOnMap.Location = new System.Drawing.Point(-3, 3);
						this.btnShowOnMap.Name = "btnShowOnMap";
						this.btnShowOnMap.Size = new System.Drawing.Size(158, 37);
						this.btnShowOnMap.TabIndex = 33;
						this.btnShowOnMap.Text = "Show on Map";
						this.btnShowOnMap.UseVisualStyleBackColor = false;
						this.btnShowOnMap.Click += new System.EventHandler(this.btnShowOnMap_Click);
						// 
						// btnDelFromList
						// 
						this.btnDelFromList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.btnDelFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
						this.btnDelFromList.Enabled = false;
						this.btnDelFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnDelFromList.ForeColor = System.Drawing.Color.White;
						this.btnDelFromList.Location = new System.Drawing.Point(161, 3);
						this.btnDelFromList.Name = "btnDelFromList";
						this.btnDelFromList.Size = new System.Drawing.Size(68, 37);
						this.btnDelFromList.TabIndex = 32;
						this.btnDelFromList.Text = "Delete";
						this.btnDelFromList.UseVisualStyleBackColor = false;
						this.btnDelFromList.Click += new System.EventHandler(this.btnDelFromList_Click);
						// 
						// btnSearchInList
						// 
						this.btnSearchInList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.btnSearchInList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
						this.btnSearchInList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnSearchInList.ForeColor = System.Drawing.Color.White;
						this.btnSearchInList.Location = new System.Drawing.Point(181, 36);
						this.btnSearchInList.Name = "btnSearchInList";
						this.btnSearchInList.Size = new System.Drawing.Size(68, 37);
						this.btnSearchInList.TabIndex = 29;
						this.btnSearchInList.Text = "Search";
						this.btnSearchInList.UseVisualStyleBackColor = false;
						this.btnSearchInList.Click += new System.EventHandler(this.btnSearchInList_Click);
						// 
						// tbxSearchInList
						// 
						this.tbxSearchInList.Location = new System.Drawing.Point(20, 43);
						this.tbxSearchInList.Name = "tbxSearchInList";
						this.tbxSearchInList.Size = new System.Drawing.Size(155, 23);
						this.tbxSearchInList.TabIndex = 28;
						// 
						// lbxSavedList
						// 
						this.lbxSavedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.lbxSavedList.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.lbxSavedList.FormattingEnabled = true;
						this.lbxSavedList.ItemHeight = 20;
						this.lbxSavedList.Location = new System.Drawing.Point(20, 86);
						this.lbxSavedList.Name = "lbxSavedList";
						this.lbxSavedList.Size = new System.Drawing.Size(229, 464);
						this.lbxSavedList.TabIndex = 27;
						this.lbxSavedList.SelectedIndexChanged += new System.EventHandler(this.lbxSavedList_SelectedIndexChanged);
						// 
						// panel1
						// 
						this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.panel1.Controls.Add(this.btnSaveToList);
						this.panel1.Controls.Add(this.mapsBrowser);
						this.panel1.Location = new System.Drawing.Point(2, 2);
						this.panel1.Name = "panel1";
						this.panel1.Size = new System.Drawing.Size(945, 653);
						this.panel1.TabIndex = 33;
						// 
						// btnSaveToList
						// 
						this.btnSaveToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.btnSaveToList.BackColor = System.Drawing.Color.White;
						this.btnSaveToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.btnSaveToList.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.btnSaveToList.ForeColor = System.Drawing.Color.Gray;
						this.btnSaveToList.Location = new System.Drawing.Point(851, 9);
						this.btnSaveToList.Name = "btnSaveToList";
						this.btnSaveToList.Size = new System.Drawing.Size(84, 48);
						this.btnSaveToList.TabIndex = 33;
						this.btnSaveToList.Text = "Save";
						this.btnSaveToList.UseVisualStyleBackColor = false;
						this.btnSaveToList.Click += new System.EventHandler(this.btnSaveToList_Click);
						// 
						// mapsBrowser
						// 
						this.mapsBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.mapsBrowser.Location = new System.Drawing.Point(-15, 0);
						this.mapsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
						this.mapsBrowser.Name = "mapsBrowser";
						this.mapsBrowser.ScriptErrorsSuppressed = true;
						this.mapsBrowser.ScrollBarsEnabled = false;
						this.mapsBrowser.Size = new System.Drawing.Size(960, 653);
						this.mapsBrowser.TabIndex = 34;
						this.mapsBrowser.Tag = "mapsBrowser";
						this.mapsBrowser.Url = new System.Uri("https://www.google.com/maps/@59.321646,18.0779646,11.92z", System.UriKind.Absolute);
						// 
						// Travel
						// 
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
						this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
						this.ClientSize = new System.Drawing.Size(1240, 653);
						this.Controls.Add(this.panel1);
						this.Controls.Add(this.gbxSavedList);
						this.MaximumSize = new System.Drawing.Size(1500, 750);
						this.MinimumSize = new System.Drawing.Size(940, 600);
						this.Name = "Travel";
						this.Text = "Travel Bucket";
						this.gbxSavedList.ResumeLayout(false);
						this.gbxSavedList.PerformLayout();
						this.panel2.ResumeLayout(false);
						this.panel1.ResumeLayout(false);
						this.ResumeLayout(false);

				}

		#endregion
		private System.Windows.Forms.GroupBox gbxSavedList;
		private System.Windows.Forms.Button btnSearchInList;
		private System.Windows.Forms.TextBox tbxSearchInList;
		private System.Windows.Forms.ListBox lbxSavedList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveToList;
		public System.Windows.Forms.WebBrowser mapsBrowser;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnShowOnMap;
		private System.Windows.Forms.Button btnDelFromList;
	}
}

