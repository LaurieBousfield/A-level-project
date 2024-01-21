namespace DatabaseCreation
{
	partial class FrmLogin
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
			this.lblHLogin = new System.Windows.Forms.Label();
			this.lblLUserName = new System.Windows.Forms.Label();
			this.txtLUserName = new System.Windows.Forms.TextBox();
			this.txtLPassword = new System.Windows.Forms.TextBox();
			this.lblLPassword = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lbLIncorrect = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblHLogin
			// 
			this.lblHLogin.AutoSize = true;
			this.lblHLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.lblHLogin.Location = new System.Drawing.Point(39, 18);
			this.lblHLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHLogin.Name = "lblHLogin";
			this.lblHLogin.Size = new System.Drawing.Size(74, 24);
			this.lblHLogin.TabIndex = 0;
			this.lblHLogin.Text = "Login: ";
			// 
			// lblLUserName
			// 
			this.lblLUserName.AutoSize = true;
			this.lblLUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblLUserName.Location = new System.Drawing.Point(40, 56);
			this.lblLUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLUserName.Name = "lblLUserName";
			this.lblLUserName.Size = new System.Drawing.Size(141, 17);
			this.lblLUserName.TabIndex = 2;
			this.lblLUserName.Text = "Enter your username";
			// 
			// txtLUserName
			// 
			this.txtLUserName.Location = new System.Drawing.Point(42, 77);
			this.txtLUserName.Margin = new System.Windows.Forms.Padding(2);
			this.txtLUserName.Name = "txtLUserName";
			this.txtLUserName.Size = new System.Drawing.Size(217, 20);
			this.txtLUserName.TabIndex = 3;
			// 
			// txtLPassword
			// 
			this.txtLPassword.Location = new System.Drawing.Point(42, 136);
			this.txtLPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtLPassword.Name = "txtLPassword";
			this.txtLPassword.Size = new System.Drawing.Size(217, 20);
			this.txtLPassword.TabIndex = 5;
			this.txtLPassword.UseSystemPasswordChar = true;
			// 
			// lblLPassword
			// 
			this.lblLPassword.AutoSize = true;
			this.lblLPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblLPassword.Location = new System.Drawing.Point(40, 115);
			this.lblLPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLPassword.Name = "lblLPassword";
			this.lblLPassword.Size = new System.Drawing.Size(138, 17);
			this.lblLPassword.TabIndex = 4;
			this.lblLPassword.Text = "Enter your password";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(42, 188);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(215, 30);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lbLIncorrect
			// 
			this.lbLIncorrect.AutoSize = true;
			this.lbLIncorrect.ForeColor = System.Drawing.Color.DarkRed;
			this.lbLIncorrect.Location = new System.Drawing.Point(43, 162);
			this.lbLIncorrect.Name = "lbLIncorrect";
			this.lbLIncorrect.Size = new System.Drawing.Size(159, 13);
			this.lbLIncorrect.TabIndex = 7;
			this.lbLIncorrect.Text = "Username or password incorrect";
			this.lbLIncorrect.Visible = false;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(299, 245);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtLPassword);
			this.Controls.Add(this.lblLPassword);
			this.Controls.Add(this.txtLUserName);
			this.Controls.Add(this.lblLUserName);
			this.Controls.Add(this.lblHLogin);
			this.Controls.Add(this.lbLIncorrect);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login ";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHLogin;
		private System.Windows.Forms.Label lblLUserName;
		private System.Windows.Forms.TextBox txtLUserName;
		private System.Windows.Forms.TextBox txtLPassword;
		private System.Windows.Forms.Label lblLPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lbLIncorrect;
	}
}