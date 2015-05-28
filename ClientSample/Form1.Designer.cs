namespace ClientSample
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.maxLength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.sleepTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Increase at line 11";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(73, 174);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Random";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// maxLength
			// 
			this.maxLength.Location = new System.Drawing.Point(102, 81);
			this.maxLength.Name = "maxLength";
			this.maxLength.Size = new System.Drawing.Size(100, 22);
			this.maxLength.TabIndex = 2;
			this.maxLength.Text = "2000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "MaxLength";
			// 
			// sleepTextbox
			// 
			this.sleepTextbox.Location = new System.Drawing.Point(102, 126);
			this.sleepTextbox.Name = "sleepTextbox";
			this.sleepTextbox.Size = new System.Drawing.Size(100, 22);
			this.sleepTextbox.TabIndex = 4;
			this.sleepTextbox.Text = "30000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Sleep";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.sleepTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.maxLength);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox maxLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sleepTextbox;
		private System.Windows.Forms.Label label2;
	}
}

