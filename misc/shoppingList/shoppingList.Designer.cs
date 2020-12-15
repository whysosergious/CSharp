namespace shoppingList {
		partial class shoppingList {
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
						this.btnRegister = new System.Windows.Forms.Button();
						this.lbxList = new System.Windows.Forms.ListBox();
						this.rbnWeight = new System.Windows.Forms.RadioButton();
						this.lblItem = new System.Windows.Forms.Label();
						this.gbxType = new System.Windows.Forms.GroupBox();
						this.rbnArticle = new System.Windows.Forms.RadioButton();
						this.tbxItem = new System.Windows.Forms.TextBox();
						this.tbxPrice = new System.Windows.Forms.TextBox();
						this.lblPrice = new System.Windows.Forms.Label();
						this.tbxAmount = new System.Windows.Forms.TextBox();
						this.lblAmount = new System.Windows.Forms.Label();
						this.tbxTotPrice = new System.Windows.Forms.TextBox();
						this.label4 = new System.Windows.Forms.Label();
						this.gbxType.SuspendLayout();
						this.SuspendLayout();
						// 
						// btnRegister
						// 
						this.btnRegister.Location = new System.Drawing.Point(131, 330);
						this.btnRegister.Name = "btnRegister";
						this.btnRegister.Size = new System.Drawing.Size(163, 41);
						this.btnRegister.TabIndex = 0;
						this.btnRegister.Text = "Add";
						this.btnRegister.UseVisualStyleBackColor = true;
						this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
						// 
						// lbxList
						// 
						this.lbxList.FormattingEnabled = true;
						this.lbxList.ItemHeight = 16;
						this.lbxList.Location = new System.Drawing.Point(332, 47);
						this.lbxList.Name = "lbxList";
						this.lbxList.Size = new System.Drawing.Size(273, 340);
						this.lbxList.TabIndex = 1;
						// 
						// rbnWeight
						// 
						this.rbnWeight.AutoSize = true;
						this.rbnWeight.Location = new System.Drawing.Point(23, 71);
						this.rbnWeight.Name = "rbnWeight";
						this.rbnWeight.Size = new System.Drawing.Size(93, 21);
						this.rbnWeight.TabIndex = 2;
						this.rbnWeight.Text = "By Weight";
						this.rbnWeight.UseVisualStyleBackColor = true;
						// 
						// lblItem
						// 
						this.lblItem.AutoSize = true;
						this.lblItem.Location = new System.Drawing.Point(37, 50);
						this.lblItem.Name = "lblItem";
						this.lblItem.Size = new System.Drawing.Size(34, 17);
						this.lblItem.TabIndex = 3;
						this.lblItem.Text = "Item";
						// 
						// gbxType
						// 
						this.gbxType.Controls.Add(this.rbnArticle);
						this.gbxType.Controls.Add(this.rbnWeight);
						this.gbxType.Location = new System.Drawing.Point(131, 176);
						this.gbxType.Name = "gbxType";
						this.gbxType.Size = new System.Drawing.Size(163, 113);
						this.gbxType.TabIndex = 4;
						this.gbxType.TabStop = false;
						this.gbxType.Text = "Type";
						// 
						// rbnArticle
						// 
						this.rbnArticle.AutoSize = true;
						this.rbnArticle.Checked = true;
						this.rbnArticle.Location = new System.Drawing.Point(23, 35);
						this.rbnArticle.Name = "rbnArticle";
						this.rbnArticle.Size = new System.Drawing.Size(88, 21);
						this.rbnArticle.TabIndex = 3;
						this.rbnArticle.TabStop = true;
						this.rbnArticle.Text = "By Article";
						this.rbnArticle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
						this.rbnArticle.UseVisualStyleBackColor = true;
						// 
						// tbxItem
						// 
						this.tbxItem.Location = new System.Drawing.Point(117, 47);
						this.tbxItem.Name = "tbxItem";
						this.tbxItem.Size = new System.Drawing.Size(177, 22);
						this.tbxItem.TabIndex = 5;
						// 
						// tbxPrice
						// 
						this.tbxPrice.Location = new System.Drawing.Point(117, 89);
						this.tbxPrice.Name = "tbxPrice";
						this.tbxPrice.Size = new System.Drawing.Size(177, 22);
						this.tbxPrice.TabIndex = 7;
						// 
						// lblPrice
						// 
						this.lblPrice.AutoSize = true;
						this.lblPrice.Location = new System.Drawing.Point(37, 92);
						this.lblPrice.Name = "lblPrice";
						this.lblPrice.Size = new System.Drawing.Size(40, 17);
						this.lblPrice.TabIndex = 6;
						this.lblPrice.Text = "Price";
						// 
						// tbxAmount
						// 
						this.tbxAmount.Location = new System.Drawing.Point(117, 130);
						this.tbxAmount.Name = "tbxAmount";
						this.tbxAmount.Size = new System.Drawing.Size(177, 22);
						this.tbxAmount.TabIndex = 9;
						// 
						// lblAmount
						// 
						this.lblAmount.AutoSize = true;
						this.lblAmount.Location = new System.Drawing.Point(37, 133);
						this.lblAmount.Name = "lblAmount";
						this.lblAmount.Size = new System.Drawing.Size(56, 17);
						this.lblAmount.TabIndex = 8;
						this.lblAmount.Text = "Amount";
						// 
						// tbxTotPrice
						// 
						this.tbxTotPrice.Location = new System.Drawing.Point(425, 405);
						this.tbxTotPrice.Name = "tbxTotPrice";
						this.tbxTotPrice.Size = new System.Drawing.Size(180, 22);
						this.tbxTotPrice.TabIndex = 11;
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(329, 408);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(76, 17);
						this.label4.TabIndex = 10;
						this.label4.Text = "Total (sek)";
						// 
						// shoppingList
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(634, 459);
						this.Controls.Add(this.tbxTotPrice);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.tbxAmount);
						this.Controls.Add(this.lblAmount);
						this.Controls.Add(this.tbxPrice);
						this.Controls.Add(this.lblPrice);
						this.Controls.Add(this.tbxItem);
						this.Controls.Add(this.gbxType);
						this.Controls.Add(this.lblItem);
						this.Controls.Add(this.lbxList);
						this.Controls.Add(this.btnRegister);
						this.Name = "shoppingList";
						this.Text = "Shopping List";
						this.gbxType.ResumeLayout(false);
						this.gbxType.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.ListBox lbxList;
		private System.Windows.Forms.RadioButton rbnWeight;
		private System.Windows.Forms.Label lblItem;
		private System.Windows.Forms.GroupBox gbxType;
		private System.Windows.Forms.RadioButton rbnArticle;
		private System.Windows.Forms.TextBox tbxItem;
		private System.Windows.Forms.TextBox tbxPrice;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.TextBox tbxAmount;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.TextBox tbxTotPrice;
		private System.Windows.Forms.Label label4;
	}
}

