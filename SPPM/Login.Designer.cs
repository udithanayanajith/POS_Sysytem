namespace SPPM
{
	partial class Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_uname = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_pws = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Moonbeam", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(668, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(725, 81);
			this.label1.TabIndex = 0;
			this.label1.Text = "Wickrama Textile Login";
			// 
			// txt_uname
			// 
			this.txt_uname.Font = new System.Drawing.Font("Moonbeam", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_uname.Location = new System.Drawing.Point(871, 427);
			this.txt_uname.Name = "txt_uname";
			this.txt_uname.Size = new System.Drawing.Size(509, 56);
			this.txt_uname.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Moonbeam", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(871, 641);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(522, 59);
			this.button1.TabIndex = 3;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Moonbeam", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(548, 430);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 48);
			this.label2.TabIndex = 4;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Moonbeam", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(558, 527);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 48);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// txt_pws
			// 
			this.txt_pws.Font = new System.Drawing.Font("Moonbeam", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_pws.Location = new System.Drawing.Point(871, 532);
			this.txt_pws.Name = "txt_pws";
			this.txt_pws.PasswordChar = '*';
			this.txt_pws.Size = new System.Drawing.Size(509, 56);
			this.txt_pws.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1420, 279);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1924, 973);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_pws);
			this.Controls.Add(this.txt_uname);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = " ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_uname;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_pws;
		private System.Windows.Forms.Button button2;
	}
}

