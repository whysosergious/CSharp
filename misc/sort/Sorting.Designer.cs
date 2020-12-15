namespace sort {
		partial class Sorting {
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
						this.tbxName = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.lbxList = new System.Windows.Forms.ListBox();
						this.btnRegister = new System.Windows.Forms.Button();
						this.label2 = new System.Windows.Forms.Label();
						this.tbxScore = new System.Windows.Forms.TextBox();
						this.btnSort = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// tbxName
						// 
						this.tbxName.Location = new System.Drawing.Point(86, 34);
						this.tbxName.Name = "tbxName";
						this.tbxName.Size = new System.Drawing.Size(182, 22);
						this.tbxName.TabIndex = 0;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(26, 37);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(45, 17);
						this.label1.TabIndex = 1;
						this.label1.Text = "Name";
						// 
						// lbxList
						// 
						this.lbxList.FormattingEnabled = true;
						this.lbxList.ItemHeight = 16;
						this.lbxList.Location = new System.Drawing.Point(12, 165);
						this.lbxList.Name = "lbxList";
						this.lbxList.Size = new System.Drawing.Size(454, 196);
						this.lbxList.TabIndex = 2;
						// 
						// btnRegister
						// 
						this.btnRegister.Location = new System.Drawing.Point(298, 46);
						this.btnRegister.Name = "btnRegister";
						this.btnRegister.Size = new System.Drawing.Size(157, 38);
						this.btnRegister.TabIndex = 3;
						this.btnRegister.Text = "Add";
						this.btnRegister.UseVisualStyleBackColor = true;
						this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(26, 90);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(45, 17);
						this.label2.TabIndex = 5;
						this.label2.Text = "Score";
						// 
						// tbxScore
						// 
						this.tbxScore.Location = new System.Drawing.Point(86, 87);
						this.tbxScore.Name = "tbxScore";
						this.tbxScore.Size = new System.Drawing.Size(182, 22);
						this.tbxScore.TabIndex = 4;
						// 
						// btnSort
						// 
						this.btnSort.Location = new System.Drawing.Point(298, 110);
						this.btnSort.Name = "btnSort";
						this.btnSort.Size = new System.Drawing.Size(157, 38);
						this.btnSort.TabIndex = 6;
						this.btnSort.Text = "Sort";
						this.btnSort.UseVisualStyleBackColor = true;
						this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
						// 
						// Sorting
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(480, 374);
						this.Controls.Add(this.btnSort);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.tbxScore);
						this.Controls.Add(this.btnRegister);
						this.Controls.Add(this.lbxList);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.tbxName);
						this.Name = "Sorting";
						this.Text = "Sort by name";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbxList;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxScore;
		private System.Windows.Forms.Button btnSort;
	}
}

