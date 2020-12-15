namespace Bank {
		partial class xrsBank {
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
						this.gbxOpenAccount = new System.Windows.Forms.GroupBox();
						this.label4 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.btnRegister = new System.Windows.Forms.Button();
						this.tbxCredit = new System.Windows.Forms.TextBox();
						this.tbxInterestRate = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.tbxAccountNr = new System.Windows.Forms.TextBox();
						this.btnWithdraw = new System.Windows.Forms.Button();
						this.btnDeposit = new System.Windows.Forms.Button();
						this.groupBox2 = new System.Windows.Forms.GroupBox();
						this.label2 = new System.Windows.Forms.Label();
						this.tbxAmount = new System.Windows.Forms.TextBox();
						this.lbxAccounts = new System.Windows.Forms.ListBox();
						this.btnUpdateWI = new System.Windows.Forms.Button();
						this.gbxOpenAccount.SuspendLayout();
						this.groupBox2.SuspendLayout();
						this.SuspendLayout();
						// 
						// gbxOpenAccount
						// 
						this.gbxOpenAccount.Controls.Add(this.label4);
						this.gbxOpenAccount.Controls.Add(this.label3);
						this.gbxOpenAccount.Controls.Add(this.btnRegister);
						this.gbxOpenAccount.Controls.Add(this.tbxCredit);
						this.gbxOpenAccount.Controls.Add(this.tbxInterestRate);
						this.gbxOpenAccount.Controls.Add(this.label1);
						this.gbxOpenAccount.Controls.Add(this.tbxAccountNr);
						this.gbxOpenAccount.Location = new System.Drawing.Point(375, 12);
						this.gbxOpenAccount.Name = "gbxOpenAccount";
						this.gbxOpenAccount.Size = new System.Drawing.Size(347, 203);
						this.gbxOpenAccount.TabIndex = 0;
						this.gbxOpenAccount.TabStop = false;
						this.gbxOpenAccount.Text = "Create Account";
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(33, 116);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(45, 17);
						this.label4.TabIndex = 6;
						this.label4.Text = "Credit";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(33, 75);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(89, 17);
						this.label3.TabIndex = 5;
						this.label3.Text = "Interest Rate";
						// 
						// btnRegister
						// 
						this.btnRegister.Location = new System.Drawing.Point(153, 159);
						this.btnRegister.Name = "btnRegister";
						this.btnRegister.Size = new System.Drawing.Size(148, 29);
						this.btnRegister.TabIndex = 2;
						this.btnRegister.Text = "Register";
						this.btnRegister.UseVisualStyleBackColor = true;
						this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
						// 
						// tbxCredit
						// 
						this.tbxCredit.Location = new System.Drawing.Point(136, 113);
						this.tbxCredit.Name = "tbxCredit";
						this.tbxCredit.Size = new System.Drawing.Size(165, 22);
						this.tbxCredit.TabIndex = 4;
						// 
						// tbxInterestRate
						// 
						this.tbxInterestRate.Location = new System.Drawing.Point(136, 72);
						this.tbxInterestRate.Name = "tbxInterestRate";
						this.tbxInterestRate.Size = new System.Drawing.Size(165, 22);
						this.tbxInterestRate.TabIndex = 3;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(33, 38);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(74, 17);
						this.label1.TabIndex = 1;
						this.label1.Text = "AccountNr";
						// 
						// tbxAccountNr
						// 
						this.tbxAccountNr.Location = new System.Drawing.Point(136, 35);
						this.tbxAccountNr.Name = "tbxAccountNr";
						this.tbxAccountNr.Size = new System.Drawing.Size(165, 22);
						this.tbxAccountNr.TabIndex = 1;
						// 
						// btnWithdraw
						// 
						this.btnWithdraw.Location = new System.Drawing.Point(163, 159);
						this.btnWithdraw.Name = "btnWithdraw";
						this.btnWithdraw.Size = new System.Drawing.Size(148, 29);
						this.btnWithdraw.TabIndex = 1;
						this.btnWithdraw.Text = "Withdraw";
						this.btnWithdraw.UseVisualStyleBackColor = true;
						this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
						// 
						// btnDeposit
						// 
						this.btnDeposit.Location = new System.Drawing.Point(163, 116);
						this.btnDeposit.Name = "btnDeposit";
						this.btnDeposit.Size = new System.Drawing.Size(148, 29);
						this.btnDeposit.TabIndex = 2;
						this.btnDeposit.Text = "Deposit";
						this.btnDeposit.UseVisualStyleBackColor = true;
						this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
						// 
						// groupBox2
						// 
						this.groupBox2.Controls.Add(this.label2);
						this.groupBox2.Controls.Add(this.btnWithdraw);
						this.groupBox2.Controls.Add(this.btnDeposit);
						this.groupBox2.Controls.Add(this.tbxAmount);
						this.groupBox2.Location = new System.Drawing.Point(12, 12);
						this.groupBox2.Name = "groupBox2";
						this.groupBox2.Size = new System.Drawing.Size(347, 203);
						this.groupBox2.TabIndex = 5;
						this.groupBox2.TabStop = false;
						this.groupBox2.Text = "Withdraw/Deposit";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(33, 38);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(56, 17);
						this.label2.TabIndex = 1;
						this.label2.Text = "Amount";
						// 
						// tbxAmount
						// 
						this.tbxAmount.Location = new System.Drawing.Point(136, 35);
						this.tbxAmount.Name = "tbxAmount";
						this.tbxAmount.Size = new System.Drawing.Size(165, 22);
						this.tbxAmount.TabIndex = 1;
						// 
						// lbxAccounts
						// 
						this.lbxAccounts.FormattingEnabled = true;
						this.lbxAccounts.ItemHeight = 16;
						this.lbxAccounts.Location = new System.Drawing.Point(737, 20);
						this.lbxAccounts.Name = "lbxAccounts";
						this.lbxAccounts.Size = new System.Drawing.Size(368, 132);
						this.lbxAccounts.TabIndex = 6;
						// 
						// btnUpdateWI
						// 
						this.btnUpdateWI.Location = new System.Drawing.Point(737, 171);
						this.btnUpdateWI.Name = "btnUpdateWI";
						this.btnUpdateWI.Size = new System.Drawing.Size(368, 29);
						this.btnUpdateWI.TabIndex = 7;
						this.btnUpdateWI.Text = "Add Interest";
						this.btnUpdateWI.UseVisualStyleBackColor = true;
						this.btnUpdateWI.Click += new System.EventHandler(this.btnUpdateWI_Click);
						// 
						// xrsBank
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(1117, 233);
						this.Controls.Add(this.btnUpdateWI);
						this.Controls.Add(this.lbxAccounts);
						this.Controls.Add(this.groupBox2);
						this.Controls.Add(this.gbxOpenAccount);
						this.Name = "xrsBank";
						this.Text = "Form1";
						this.gbxOpenAccount.ResumeLayout(false);
						this.gbxOpenAccount.PerformLayout();
						this.groupBox2.ResumeLayout(false);
						this.groupBox2.PerformLayout();
						this.ResumeLayout(false);

				}

		#endregion

		private System.Windows.Forms.GroupBox gbxOpenAccount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox tbxCredit;
		private System.Windows.Forms.TextBox tbxInterestRate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxAccountNr;
		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxAmount;
		private System.Windows.Forms.ListBox lbxAccounts;
		private System.Windows.Forms.Button btnUpdateWI;
	}
}

