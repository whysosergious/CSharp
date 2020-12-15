namespace vehicleRegister {
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
						this.regnr = new System.Windows.Forms.TextBox();
						this.make = new System.Windows.Forms.TextBox();
						this.model = new System.Windows.Forms.TextBox();
						this.registerBtn = new System.Windows.Forms.Button();
						this.All = new System.Windows.Forms.RadioButton();
						this.Cars = new System.Windows.Forms.RadioButton();
						this.Bikes = new System.Windows.Forms.RadioButton();
						this.registerWndw = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.label4 = new System.Windows.Forms.Label();
						this.label5 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// regnr
						// 
						this.regnr.Location = new System.Drawing.Point(176, 105);
						this.regnr.Name = "regnr";
						this.regnr.Size = new System.Drawing.Size(182, 22);
						this.regnr.TabIndex = 0;
						// 
						// make
						// 
						this.make.Location = new System.Drawing.Point(176, 157);
						this.make.Name = "make";
						this.make.Size = new System.Drawing.Size(182, 22);
						this.make.TabIndex = 1;
						// 
						// model
						// 
						this.model.Location = new System.Drawing.Point(176, 213);
						this.model.Name = "model";
						this.model.Size = new System.Drawing.Size(182, 22);
						this.model.TabIndex = 2;
						// 
						// registerBtn
						// 
						this.registerBtn.Location = new System.Drawing.Point(95, 354);
						this.registerBtn.Name = "registerBtn";
						this.registerBtn.Size = new System.Drawing.Size(177, 36);
						this.registerBtn.TabIndex = 3;
						this.registerBtn.Text = "Register";
						this.registerBtn.UseVisualStyleBackColor = true;
						// 
						// All
						// 
						this.All.AutoSize = true;
						this.All.Location = new System.Drawing.Point(400, 383);
						this.All.Name = "All";
						this.All.Size = new System.Drawing.Size(44, 21);
						this.All.TabIndex = 4;
						this.All.TabStop = true;
						this.All.Text = "All";
						this.All.UseVisualStyleBackColor = true;
						this.All.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
						// 
						// Cars
						// 
						this.Cars.AutoSize = true;
						this.Cars.Location = new System.Drawing.Point(535, 383);
						this.Cars.Name = "Cars";
						this.Cars.Size = new System.Drawing.Size(58, 21);
						this.Cars.TabIndex = 5;
						this.Cars.TabStop = true;
						this.Cars.Text = "Cars";
						this.Cars.UseVisualStyleBackColor = true;
						// 
						// Bikes
						// 
						this.Bikes.AutoSize = true;
						this.Bikes.Location = new System.Drawing.Point(666, 383);
						this.Bikes.Name = "Bikes";
						this.Bikes.Size = new System.Drawing.Size(63, 21);
						this.Bikes.TabIndex = 6;
						this.Bikes.TabStop = true;
						this.Bikes.Text = "Bikes";
						this.Bikes.UseVisualStyleBackColor = true;
						// 
						// registerWndw
						// 
						this.registerWndw.Location = new System.Drawing.Point(422, 92);
						this.registerWndw.Multiline = true;
						this.registerWndw.Name = "registerWndw";
						this.registerWndw.Size = new System.Drawing.Size(306, 219);
						this.registerWndw.TabIndex = 7;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(73, 109);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(60, 17);
						this.label1.TabIndex = 8;
						this.label1.Text = "Plate-Nr";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(73, 160);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(42, 17);
						this.label2.TabIndex = 9;
						this.label2.Text = "Make";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(73, 216);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(46, 17);
						this.label3.TabIndex = 10;
						this.label3.Text = "Model";
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(73, 284);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(40, 17);
						this.label4.TabIndex = 11;
						this.label4.Text = "Type";
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Location = new System.Drawing.Point(419, 56);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(46, 17);
						this.label5.TabIndex = 12;
						this.label5.Text = "label5";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.label5);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.registerWndw);
						this.Controls.Add(this.Bikes);
						this.Controls.Add(this.Cars);
						this.Controls.Add(this.All);
						this.Controls.Add(this.registerBtn);
						this.Controls.Add(this.model);
						this.Controls.Add(this.make);
						this.Controls.Add(this.regnr);
						this.Name = "Form1";
						this.Text = "Form1";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.TextBox regnr;
		private System.Windows.Forms.TextBox make;
		private System.Windows.Forms.TextBox model;
		private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.RadioButton All;
		private System.Windows.Forms.RadioButton Cars;
		private System.Windows.Forms.RadioButton Bikes;
		private System.Windows.Forms.TextBox registerWndw;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.Label label5;
		}
}

