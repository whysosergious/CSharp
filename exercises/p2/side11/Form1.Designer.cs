namespace side11 {
		partial class Form1 {
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
						this.tbxSvar = new System.Windows.Forms.TextBox();
						this.tbxTal1 = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.btnKör = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// tbxSvar
						// 
						this.tbxSvar.Location = new System.Drawing.Point(168, 227);
						this.tbxSvar.Name = "tbxSvar";
						this.tbxSvar.Size = new System.Drawing.Size(237, 22);
						this.tbxSvar.TabIndex = 0;
						// 
						// tbxTal1
						// 
						this.tbxTal1.Location = new System.Drawing.Point(168, 69);
						this.tbxTal1.Name = "tbxTal1";
						this.tbxTal1.Size = new System.Drawing.Size(237, 22);
						this.tbxTal1.TabIndex = 1;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(39, 230);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(95, 17);
						this.label1.TabIndex = 2;
						this.label1.Text = "Resultatet blir";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(37, 72);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(97, 17);
						this.label2.TabIndex = 3;
						this.label2.Text = "Skriv ett heltal";
						// 
						// btnKör
						// 
						this.btnKör.Location = new System.Drawing.Point(185, 133);
						this.btnKör.Name = "btnKör";
						this.btnKör.Size = new System.Drawing.Size(151, 40);
						this.btnKör.TabIndex = 4;
						this.btnKör.Text = "Addera 5";
						this.btnKör.UseVisualStyleBackColor = true;
						this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(481, 333);
						this.Controls.Add(this.btnKör);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.tbxTal1);
						this.Controls.Add(this.tbxSvar);
						this.Name = "Form1";
						this.Text = "First Window";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.TextBox tbxSvar;
		private System.Windows.Forms.TextBox tbxTal1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnKör;
	}
}

