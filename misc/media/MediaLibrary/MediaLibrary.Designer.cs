namespace MediaLibrary {
		partial class MediaLibrary {
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
						this.tbxBookTitle = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.btnRegBook = new System.Windows.Forms.Button();
						this.tbxBookPages = new System.Windows.Forms.TextBox();
						this.groupBox1 = new System.Windows.Forms.GroupBox();
						this.label2 = new System.Windows.Forms.Label();
						this.groupBox2 = new System.Windows.Forms.GroupBox();
						this.label3 = new System.Windows.Forms.Label();
						this.tbxSoundTitle = new System.Windows.Forms.TextBox();
						this.tbxSoundRuntime = new System.Windows.Forms.TextBox();
						this.btnRegSound = new System.Windows.Forms.Button();
						this.label4 = new System.Windows.Forms.Label();
						this.groupBox3 = new System.Windows.Forms.GroupBox();
						this.label7 = new System.Windows.Forms.Label();
						this.tbxVideoRes = new System.Windows.Forms.TextBox();
						this.label5 = new System.Windows.Forms.Label();
						this.tbxVideoTitle = new System.Windows.Forms.TextBox();
						this.tbxVideoRuntime = new System.Windows.Forms.TextBox();
						this.btnRegVideo = new System.Windows.Forms.Button();
						this.label6 = new System.Windows.Forms.Label();
						this.label8 = new System.Windows.Forms.Label();
						this.lbxLibrary = new System.Windows.Forms.ListBox();
						this.comboBox1 = new System.Windows.Forms.ComboBox();
						this.groupBox1.SuspendLayout();
						this.groupBox2.SuspendLayout();
						this.groupBox3.SuspendLayout();
						this.SuspendLayout();
						// 
						// tbxBookTitle
						// 
						this.tbxBookTitle.Location = new System.Drawing.Point(91, 42);
						this.tbxBookTitle.Name = "tbxBookTitle";
						this.tbxBookTitle.Size = new System.Drawing.Size(138, 22);
						this.tbxBookTitle.TabIndex = 0;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(18, 45);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(35, 17);
						this.label1.TabIndex = 1;
						this.label1.Text = "Title";
						// 
						// btnRegBook
						// 
						this.btnRegBook.Location = new System.Drawing.Point(21, 170);
						this.btnRegBook.Name = "btnRegBook";
						this.btnRegBook.Size = new System.Drawing.Size(208, 34);
						this.btnRegBook.TabIndex = 2;
						this.btnRegBook.Text = "Reg Book";
						this.btnRegBook.UseVisualStyleBackColor = true;
						this.btnRegBook.Click += new System.EventHandler(this.btnRegBook_Click);
						// 
						// tbxBookPages
						// 
						this.tbxBookPages.Location = new System.Drawing.Point(91, 84);
						this.tbxBookPages.Name = "tbxBookPages";
						this.tbxBookPages.Size = new System.Drawing.Size(138, 22);
						this.tbxBookPages.TabIndex = 6;
						// 
						// groupBox1
						// 
						this.groupBox1.Controls.Add(this.label2);
						this.groupBox1.Controls.Add(this.tbxBookTitle);
						this.groupBox1.Controls.Add(this.tbxBookPages);
						this.groupBox1.Controls.Add(this.btnRegBook);
						this.groupBox1.Controls.Add(this.label1);
						this.groupBox1.Location = new System.Drawing.Point(12, 23);
						this.groupBox1.Name = "groupBox1";
						this.groupBox1.Size = new System.Drawing.Size(258, 222);
						this.groupBox1.TabIndex = 8;
						this.groupBox1.TabStop = false;
						this.groupBox1.Text = "Book";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(18, 87);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(48, 17);
						this.label2.TabIndex = 7;
						this.label2.Text = "Pages";
						// 
						// groupBox2
						// 
						this.groupBox2.Controls.Add(this.label3);
						this.groupBox2.Controls.Add(this.tbxSoundTitle);
						this.groupBox2.Controls.Add(this.tbxSoundRuntime);
						this.groupBox2.Controls.Add(this.btnRegSound);
						this.groupBox2.Controls.Add(this.label4);
						this.groupBox2.Location = new System.Drawing.Point(288, 23);
						this.groupBox2.Name = "groupBox2";
						this.groupBox2.Size = new System.Drawing.Size(258, 222);
						this.groupBox2.TabIndex = 9;
						this.groupBox2.TabStop = false;
						this.groupBox2.Text = "Sound Media";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(18, 87);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(60, 17);
						this.label3.TabIndex = 7;
						this.label3.Text = "Runtime";
						// 
						// tbxSoundTitle
						// 
						this.tbxSoundTitle.Location = new System.Drawing.Point(91, 42);
						this.tbxSoundTitle.Name = "tbxSoundTitle";
						this.tbxSoundTitle.Size = new System.Drawing.Size(138, 22);
						this.tbxSoundTitle.TabIndex = 0;
						// 
						// tbxSoundRuntime
						// 
						this.tbxSoundRuntime.Location = new System.Drawing.Point(91, 84);
						this.tbxSoundRuntime.Name = "tbxSoundRuntime";
						this.tbxSoundRuntime.Size = new System.Drawing.Size(138, 22);
						this.tbxSoundRuntime.TabIndex = 6;
						// 
						// btnRegSound
						// 
						this.btnRegSound.Location = new System.Drawing.Point(21, 170);
						this.btnRegSound.Name = "btnRegSound";
						this.btnRegSound.Size = new System.Drawing.Size(208, 34);
						this.btnRegSound.TabIndex = 2;
						this.btnRegSound.Text = "Reg Sound Media";
						this.btnRegSound.UseVisualStyleBackColor = true;
						this.btnRegSound.Click += new System.EventHandler(this.btnRegSound_Click);
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(18, 45);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(35, 17);
						this.label4.TabIndex = 1;
						this.label4.Text = "Title";
						// 
						// groupBox3
						// 
						this.groupBox3.Controls.Add(this.label7);
						this.groupBox3.Controls.Add(this.tbxVideoRes);
						this.groupBox3.Controls.Add(this.label5);
						this.groupBox3.Controls.Add(this.tbxVideoTitle);
						this.groupBox3.Controls.Add(this.tbxVideoRuntime);
						this.groupBox3.Controls.Add(this.btnRegVideo);
						this.groupBox3.Controls.Add(this.label6);
						this.groupBox3.Location = new System.Drawing.Point(566, 23);
						this.groupBox3.Name = "groupBox3";
						this.groupBox3.Size = new System.Drawing.Size(258, 222);
						this.groupBox3.TabIndex = 10;
						this.groupBox3.TabStop = false;
						this.groupBox3.Text = "Video";
						// 
						// label7
						// 
						this.label7.AutoSize = true;
						this.label7.Location = new System.Drawing.Point(18, 128);
						this.label7.Name = "label7";
						this.label7.Size = new System.Drawing.Size(33, 17);
						this.label7.TabIndex = 9;
						this.label7.Text = "Res";
						// 
						// tbxVideoRes
						// 
						this.tbxVideoRes.Location = new System.Drawing.Point(91, 125);
						this.tbxVideoRes.Name = "tbxVideoRes";
						this.tbxVideoRes.Size = new System.Drawing.Size(138, 22);
						this.tbxVideoRes.TabIndex = 8;
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Location = new System.Drawing.Point(18, 87);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(60, 17);
						this.label5.TabIndex = 7;
						this.label5.Text = "Runtime";
						// 
						// tbxVideoTitle
						// 
						this.tbxVideoTitle.Location = new System.Drawing.Point(91, 42);
						this.tbxVideoTitle.Name = "tbxVideoTitle";
						this.tbxVideoTitle.Size = new System.Drawing.Size(138, 22);
						this.tbxVideoTitle.TabIndex = 0;
						// 
						// tbxVideoRuntime
						// 
						this.tbxVideoRuntime.Location = new System.Drawing.Point(91, 84);
						this.tbxVideoRuntime.Name = "tbxVideoRuntime";
						this.tbxVideoRuntime.Size = new System.Drawing.Size(138, 22);
						this.tbxVideoRuntime.TabIndex = 6;
						// 
						// btnRegVideo
						// 
						this.btnRegVideo.Location = new System.Drawing.Point(21, 170);
						this.btnRegVideo.Name = "btnRegVideo";
						this.btnRegVideo.Size = new System.Drawing.Size(208, 34);
						this.btnRegVideo.TabIndex = 2;
						this.btnRegVideo.Text = "Reg Video";
						this.btnRegVideo.UseVisualStyleBackColor = true;
						this.btnRegVideo.Click += new System.EventHandler(this.btnRegVideo_Click);
						// 
						// label6
						// 
						this.label6.AutoSize = true;
						this.label6.Location = new System.Drawing.Point(18, 45);
						this.label6.Name = "label6";
						this.label6.Size = new System.Drawing.Size(35, 17);
						this.label6.TabIndex = 1;
						this.label6.Text = "Title";
						// 
						// label8
						// 
						this.label8.AutoSize = true;
						this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label8.Location = new System.Drawing.Point(349, 265);
						this.label8.Name = "label8";
						this.label8.Size = new System.Drawing.Size(148, 46);
						this.label8.TabIndex = 8;
						this.label8.Text = "Library";
						// 
						// lbxLibrary
						// 
						this.lbxLibrary.FormattingEnabled = true;
						this.lbxLibrary.ItemHeight = 16;
						this.lbxLibrary.Location = new System.Drawing.Point(12, 326);
						this.lbxLibrary.Name = "lbxLibrary";
						this.lbxLibrary.Size = new System.Drawing.Size(814, 292);
						this.lbxLibrary.TabIndex = 11;
						// 
						// comboBox1
						// 
						this.comboBox1.FormattingEnabled = true;
						this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
						this.comboBox1.Location = new System.Drawing.Point(606, 265);
						this.comboBox1.Name = "comboBox1";
						this.comboBox1.Size = new System.Drawing.Size(121, 24);
						this.comboBox1.TabIndex = 12;
						// 
						// MediaLibrary
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(838, 628);
						this.Controls.Add(this.comboBox1);
						this.Controls.Add(this.lbxLibrary);
						this.Controls.Add(this.label8);
						this.Controls.Add(this.groupBox3);
						this.Controls.Add(this.groupBox2);
						this.Controls.Add(this.groupBox1);
						this.Name = "MediaLibrary";
						this.Text = "Form1";
						this.groupBox1.ResumeLayout(false);
						this.groupBox1.PerformLayout();
						this.groupBox2.ResumeLayout(false);
						this.groupBox2.PerformLayout();
						this.groupBox3.ResumeLayout(false);
						this.groupBox3.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.TextBox tbxBookTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegBook;
		private System.Windows.Forms.TextBox tbxBookPages;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxSoundTitle;
		private System.Windows.Forms.TextBox tbxSoundRuntime;
		private System.Windows.Forms.Button btnRegSound;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbxVideoRes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbxVideoTitle;
		private System.Windows.Forms.TextBox tbxVideoRuntime;
		private System.Windows.Forms.Button btnRegVideo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox lbxLibrary;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

