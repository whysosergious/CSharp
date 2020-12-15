namespace UDPClient {
		partial class UDPClient {
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
						this.label2 = new System.Windows.Forms.Label();
						this.lblHostScore = new System.Windows.Forms.Label();
						this.label1 = new System.Windows.Forms.Label();
						this.lblConStatus = new System.Windows.Forms.Label();
						this.btnIncrement = new System.Windows.Forms.Button();
						this.lblClientScore = new System.Windows.Forms.Label();
						this.btnConnect = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.ForeColor = System.Drawing.Color.Coral;
						this.label2.Location = new System.Drawing.Point(208, 84);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(71, 17);
						this.label2.TabIndex = 17;
						this.label2.Text = "Opponent";
						// 
						// lblHostScore
						// 
						this.lblHostScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.lblHostScore.ForeColor = System.Drawing.Color.Coral;
						this.lblHostScore.Location = new System.Drawing.Point(42, 114);
						this.lblHostScore.Name = "lblHostScore";
						this.lblHostScore.Size = new System.Drawing.Size(408, 46);
						this.lblHostScore.TabIndex = 16;
						this.lblHostScore.Text = "0";
						this.lblHostScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label1.Location = new System.Drawing.Point(221, 258);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(47, 25);
						this.label1.TabIndex = 15;
						this.label1.Text = "You";
						// 
						// lblConStatus
						// 
						this.lblConStatus.AutoSize = true;
						this.lblConStatus.Location = new System.Drawing.Point(232, 20);
						this.lblConStatus.Name = "lblConStatus";
						this.lblConStatus.Size = new System.Drawing.Size(102, 17);
						this.lblConStatus.TabIndex = 14;
						this.lblConStatus.Text = "Not Connected";
						// 
						// btnIncrement
						// 
						this.btnIncrement.Location = new System.Drawing.Point(42, 369);
						this.btnIncrement.Name = "btnIncrement";
						this.btnIncrement.Size = new System.Drawing.Size(408, 72);
						this.btnIncrement.TabIndex = 13;
						this.btnIncrement.Text = "Increment";
						this.btnIncrement.UseVisualStyleBackColor = true;
						this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
						// 
						// lblClientScore
						// 
						this.lblClientScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.lblClientScore.Location = new System.Drawing.Point(42, 179);
						this.lblClientScore.Name = "lblClientScore";
						this.lblClientScore.Size = new System.Drawing.Size(408, 64);
						this.lblClientScore.TabIndex = 12;
						this.lblClientScore.Text = "0";
						this.lblClientScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
						// 
						// btnConnect
						// 
						this.btnConnect.Location = new System.Drawing.Point(395, 12);
						this.btnConnect.Name = "btnConnect";
						this.btnConnect.Size = new System.Drawing.Size(101, 33);
						this.btnConnect.TabIndex = 11;
						this.btnConnect.Text = "Connect";
						this.btnConnect.UseVisualStyleBackColor = true;
						this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
						// 
						// UDPClient
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(508, 515);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.lblHostScore);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.lblConStatus);
						this.Controls.Add(this.btnIncrement);
						this.Controls.Add(this.lblClientScore);
						this.Controls.Add(this.btnConnect);
						this.Name = "UDPClient";
						this.Text = "UDPClient";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblHostScore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblConStatus;
		private System.Windows.Forms.Button btnIncrement;
		private System.Windows.Forms.Label lblClientScore;
		private System.Windows.Forms.Button btnConnect;
	}
}

