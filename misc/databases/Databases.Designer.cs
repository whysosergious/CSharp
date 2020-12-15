namespace databases {
		partial class Databases {
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
						this.btnGetData = new System.Windows.Forms.Button();
						this.label1 = new System.Windows.Forms.Label();
						this.tbxGetByID = new System.Windows.Forms.TextBox();
						this.tbxResult = new System.Windows.Forms.TextBox();
						this.label2 = new System.Windows.Forms.Label();
						this.btnSaveData = new System.Windows.Forms.Button();
						this.tbxNewFirstName = new System.Windows.Forms.TextBox();
						this.label4 = new System.Windows.Forms.Label();
						this.tbxNewLastName = new System.Windows.Forms.TextBox();
						this.label5 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// btnGetData
						// 
						this.btnGetData.Location = new System.Drawing.Point(202, 204);
						this.btnGetData.Name = "btnGetData";
						this.btnGetData.Size = new System.Drawing.Size(141, 45);
						this.btnGetData.TabIndex = 0;
						this.btnGetData.Text = "get data";
						this.btnGetData.UseVisualStyleBackColor = true;
						this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(41, 218);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(19, 17);
						this.label1.TabIndex = 1;
						this.label1.Text = "id";
						// 
						// tbxGetByID
						// 
						this.tbxGetByID.Location = new System.Drawing.Point(76, 215);
						this.tbxGetByID.Name = "tbxGetByID";
						this.tbxGetByID.Size = new System.Drawing.Size(100, 22);
						this.tbxGetByID.TabIndex = 2;
						// 
						// tbxResult
						// 
						this.tbxResult.Location = new System.Drawing.Point(23, 323);
						this.tbxResult.Multiline = true;
						this.tbxResult.Name = "tbxResult";
						this.tbxResult.Size = new System.Drawing.Size(350, 131);
						this.tbxResult.TabIndex = 3;
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(20, 290);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(48, 17);
						this.label2.TabIndex = 4;
						this.label2.Text = "Result";
						// 
						// btnSaveData
						// 
						this.btnSaveData.Location = new System.Drawing.Point(202, 80);
						this.btnSaveData.Name = "btnSaveData";
						this.btnSaveData.Size = new System.Drawing.Size(141, 67);
						this.btnSaveData.TabIndex = 5;
						this.btnSaveData.Text = "save data";
						this.btnSaveData.UseVisualStyleBackColor = true;
						this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
						// 
						// tbxNewFirstName
						// 
						this.tbxNewFirstName.Location = new System.Drawing.Point(76, 80);
						this.tbxNewFirstName.Name = "tbxNewFirstName";
						this.tbxNewFirstName.Size = new System.Drawing.Size(100, 22);
						this.tbxNewFirstName.TabIndex = 9;
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(41, 83);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(20, 17);
						this.label4.TabIndex = 8;
						this.label4.Text = "fn";
						// 
						// tbxNewLastName
						// 
						this.tbxNewLastName.Location = new System.Drawing.Point(76, 125);
						this.tbxNewLastName.Name = "tbxNewLastName";
						this.tbxNewLastName.Size = new System.Drawing.Size(100, 22);
						this.tbxNewLastName.TabIndex = 11;
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Location = new System.Drawing.Point(41, 128);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(19, 17);
						this.label5.TabIndex = 10;
						this.label5.Text = "ln";
						// 
						// Databases
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(397, 471);
						this.Controls.Add(this.tbxNewLastName);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.tbxNewFirstName);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.btnSaveData);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.tbxResult);
						this.Controls.Add(this.tbxGetByID);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.btnGetData);
						this.Name = "Databases";
						this.Text = "Form1";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.Button btnGetData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxGetByID;
		private System.Windows.Forms.TextBox tbxResult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSaveData;
		private System.Windows.Forms.TextBox tbxNewFirstName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbxNewLastName;
		private System.Windows.Forms.Label label5;
	}
}

