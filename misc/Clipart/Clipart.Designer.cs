namespace Clipart {
		partial class Clipart {
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
						this.gbxCreate = new System.Windows.Forms.GroupBox();
						this.btnAddLine = new System.Windows.Forms.Button();
						this.btnAddCircle = new System.Windows.Forms.Button();
						this.label2 = new System.Windows.Forms.Label();
						this.tbxWidth = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.btnAddTriangle = new System.Windows.Forms.Button();
						this.tbxHeight = new System.Windows.Forms.TextBox();
						this.lbxObjects = new System.Windows.Forms.ListBox();
						this.btnCalObjArea = new System.Windows.Forms.Button();
						this.tbxTotObjArea = new System.Windows.Forms.TextBox();
						this.label3 = new System.Windows.Forms.Label();
						this.gbxCreate.SuspendLayout();
						this.SuspendLayout();
						// 
						// gbxCreate
						// 
						this.gbxCreate.Controls.Add(this.btnAddLine);
						this.gbxCreate.Controls.Add(this.btnAddCircle);
						this.gbxCreate.Controls.Add(this.label2);
						this.gbxCreate.Controls.Add(this.tbxWidth);
						this.gbxCreate.Controls.Add(this.label1);
						this.gbxCreate.Controls.Add(this.btnAddTriangle);
						this.gbxCreate.Controls.Add(this.tbxHeight);
						this.gbxCreate.Location = new System.Drawing.Point(12, 12);
						this.gbxCreate.Name = "gbxCreate";
						this.gbxCreate.Size = new System.Drawing.Size(281, 307);
						this.gbxCreate.TabIndex = 0;
						this.gbxCreate.TabStop = false;
						this.gbxCreate.Text = "Create";
						// 
						// btnAddLine
						// 
						this.btnAddLine.Location = new System.Drawing.Point(96, 255);
						this.btnAddLine.Name = "btnAddLine";
						this.btnAddLine.Size = new System.Drawing.Size(159, 35);
						this.btnAddLine.TabIndex = 9;
						this.btnAddLine.Text = "Add Line";
						this.btnAddLine.UseVisualStyleBackColor = true;
						this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
						// 
						// btnAddCircle
						// 
						this.btnAddCircle.Location = new System.Drawing.Point(96, 203);
						this.btnAddCircle.Name = "btnAddCircle";
						this.btnAddCircle.Size = new System.Drawing.Size(159, 35);
						this.btnAddCircle.TabIndex = 8;
						this.btnAddCircle.Text = "Add Circle";
						this.btnAddCircle.UseVisualStyleBackColor = true;
						this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(16, 94);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(44, 17);
						this.label2.TabIndex = 6;
						this.label2.Text = "Width";
						// 
						// tbxWidth
						// 
						this.tbxWidth.Location = new System.Drawing.Point(96, 94);
						this.tbxWidth.Name = "tbxWidth";
						this.tbxWidth.Size = new System.Drawing.Size(159, 22);
						this.tbxWidth.TabIndex = 7;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(16, 57);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(49, 17);
						this.label1.TabIndex = 3;
						this.label1.Text = "Height";
						// 
						// btnAddTriangle
						// 
						this.btnAddTriangle.Location = new System.Drawing.Point(96, 153);
						this.btnAddTriangle.Name = "btnAddTriangle";
						this.btnAddTriangle.Size = new System.Drawing.Size(159, 35);
						this.btnAddTriangle.TabIndex = 1;
						this.btnAddTriangle.Text = "Add Triangle";
						this.btnAddTriangle.UseVisualStyleBackColor = true;
						this.btnAddTriangle.Click += new System.EventHandler(this.btnAddTriangle_Click);
						// 
						// tbxHeight
						// 
						this.tbxHeight.Location = new System.Drawing.Point(96, 54);
						this.tbxHeight.Name = "tbxHeight";
						this.tbxHeight.Size = new System.Drawing.Size(159, 22);
						this.tbxHeight.TabIndex = 3;
						// 
						// lbxObjects
						// 
						this.lbxObjects.FormattingEnabled = true;
						this.lbxObjects.ItemHeight = 16;
						this.lbxObjects.Location = new System.Drawing.Point(321, 66);
						this.lbxObjects.Name = "lbxObjects";
						this.lbxObjects.Size = new System.Drawing.Size(216, 276);
						this.lbxObjects.TabIndex = 2;
						// 
						// btnCalObjArea
						// 
						this.btnCalObjArea.Location = new System.Drawing.Point(108, 366);
						this.btnCalObjArea.Name = "btnCalObjArea";
						this.btnCalObjArea.Size = new System.Drawing.Size(159, 35);
						this.btnCalObjArea.TabIndex = 10;
						this.btnCalObjArea.Text = "Calculate Obj Area";
						this.btnCalObjArea.UseVisualStyleBackColor = true;
						this.btnCalObjArea.Click += new System.EventHandler(this.btnCalObjArea_Click);
						// 
						// tbxTotObjArea
						// 
						this.tbxTotObjArea.Location = new System.Drawing.Point(321, 372);
						this.tbxTotObjArea.Name = "tbxTotObjArea";
						this.tbxTotObjArea.Size = new System.Drawing.Size(216, 22);
						this.tbxTotObjArea.TabIndex = 10;
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(318, 36);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(56, 17);
						this.label3.TabIndex = 10;
						this.label3.Text = "Obj List";
						// 
						// Clipart
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(559, 436);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.tbxTotObjArea);
						this.Controls.Add(this.btnCalObjArea);
						this.Controls.Add(this.lbxObjects);
						this.Controls.Add(this.gbxCreate);
						this.Name = "Clipart";
						this.Text = "Form1";
						this.gbxCreate.ResumeLayout(false);
						this.gbxCreate.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

		#endregion

		private System.Windows.Forms.GroupBox gbxCreate;
		private System.Windows.Forms.Button btnAddLine;
		private System.Windows.Forms.Button btnAddCircle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddTriangle;
		private System.Windows.Forms.TextBox tbxHeight;
		private System.Windows.Forms.ListBox lbxObjects;
		private System.Windows.Forms.Button btnCalObjArea;
		private System.Windows.Forms.TextBox tbxTotObjArea;
		private System.Windows.Forms.Label label3;
	}
}

