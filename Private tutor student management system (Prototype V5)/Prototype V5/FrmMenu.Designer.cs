namespace DatabaseCreation
{
	partial class FrmMenu
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
			this.btnFrmDatabaseCreation = new System.Windows.Forms.Button();
			this.btnFrmBooking = new System.Windows.Forms.Button();
			this.lblMenu = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnFrmDatabaseCreation
			// 
			this.btnFrmDatabaseCreation.Location = new System.Drawing.Point(68, 131);
			this.btnFrmDatabaseCreation.Name = "btnFrmDatabaseCreation";
			this.btnFrmDatabaseCreation.Size = new System.Drawing.Size(138, 41);
			this.btnFrmDatabaseCreation.TabIndex = 5;
			this.btnFrmDatabaseCreation.Text = "Database Management";
			this.btnFrmDatabaseCreation.UseVisualStyleBackColor = true;
			this.btnFrmDatabaseCreation.Click += new System.EventHandler(this.btnFrmDatabaseCreation_Click);
			// 
			// btnFrmBooking
			// 
			this.btnFrmBooking.Location = new System.Drawing.Point(83, 69);
			this.btnFrmBooking.Name = "btnFrmBooking";
			this.btnFrmBooking.Size = new System.Drawing.Size(111, 41);
			this.btnFrmBooking.TabIndex = 4;
			this.btnFrmBooking.Text = "Booking view";
			this.btnFrmBooking.UseVisualStyleBackColor = true;
			this.btnFrmBooking.Click += new System.EventHandler(this.btnFrmBooking_Click);
			// 
			// lblMenu
			// 
			this.lblMenu.AutoSize = true;
			this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenu.Location = new System.Drawing.Point(108, 22);
			this.lblMenu.Name = "lblMenu";
			this.lblMenu.Size = new System.Drawing.Size(69, 24);
			this.lblMenu.TabIndex = 3;
			this.lblMenu.Text = "Menu:";
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 241);
			this.Controls.Add(this.btnFrmDatabaseCreation);
			this.Controls.Add(this.btnFrmBooking);
			this.Controls.Add(this.lblMenu);
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFrmDatabaseCreation;
		private System.Windows.Forms.Button btnFrmBooking;
		private System.Windows.Forms.Label lblMenu;
	}
}