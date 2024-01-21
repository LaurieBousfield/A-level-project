namespace DatabaseCreation
{
    partial class FrmBooking
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvBookings = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpBookings = new System.Windows.Forms.DateTimePicker();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.btnViewWeek = new System.Windows.Forms.Button();
			this.btnMenuReturnFromBooking = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBookings
			// 
			this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvBookings.Location = new System.Drawing.Point(166, 19);
			this.dgvBookings.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBookings.Name = "dgvBookings";
			this.dgvBookings.RowHeadersVisible = false;
			this.dgvBookings.RowHeadersWidth = 62;
			this.dgvBookings.RowTemplate.Height = 117;
			this.dgvBookings.Size = new System.Drawing.Size(720, 373);
			this.dgvBookings.TabIndex = 0;
			this.dgvBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dgvBookings.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
			this.dgvBookings.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(225, 143);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 1;
			// 
			// dtpBookings
			// 
			this.dtpBookings.Location = new System.Drawing.Point(901, 62);
			this.dtpBookings.Margin = new System.Windows.Forms.Padding(2);
			this.dtpBookings.Name = "dtpBookings";
			this.dtpBookings.Size = new System.Drawing.Size(170, 20);
			this.dtpBookings.TabIndex = 2;
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Location = new System.Drawing.Point(898, 27);
			this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(256, 26);
			this.lblInstructions.TabIndex = 3;
			this.lblInstructions.Text = "Choose Monday of the week you would like to view. \r\nThen click the View Week butt" +
    "on.";
			// 
			// btnViewWeek
			// 
			this.btnViewWeek.Location = new System.Drawing.Point(901, 95);
			this.btnViewWeek.Margin = new System.Windows.Forms.Padding(2);
			this.btnViewWeek.Name = "btnViewWeek";
			this.btnViewWeek.Size = new System.Drawing.Size(107, 32);
			this.btnViewWeek.TabIndex = 4;
			this.btnViewWeek.Text = "View Week";
			this.btnViewWeek.UseVisualStyleBackColor = true;
			this.btnViewWeek.Click += new System.EventHandler(this.btnViewWeek_Click);
			// 
			// btnMenuReturnFromBooking
			// 
			this.btnMenuReturnFromBooking.BackColor = System.Drawing.Color.White;
			this.btnMenuReturnFromBooking.Location = new System.Drawing.Point(901, 351);
			this.btnMenuReturnFromBooking.Name = "btnMenuReturnFromBooking";
			this.btnMenuReturnFromBooking.Size = new System.Drawing.Size(107, 41);
			this.btnMenuReturnFromBooking.TabIndex = 5;
			this.btnMenuReturnFromBooking.Text = "Menu";
			this.btnMenuReturnFromBooking.UseVisualStyleBackColor = false;
			this.btnMenuReturnFromBooking.Click += new System.EventHandler(this.btnMenuReturnFromBooking_Click);
			// 
			// FrmBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1218, 528);
			this.Controls.Add(this.btnMenuReturnFromBooking);
			this.Controls.Add(this.btnViewWeek);
			this.Controls.Add(this.lblInstructions);
			this.Controls.Add(this.dtpBookings);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvBookings);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmBooking";
			this.Text = "frmBooking";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmBooking_Load);
			this.Shown += new System.EventHandler(this.frmBooking_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBookings;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnViewWeek;
		private System.Windows.Forms.Button btnMenuReturnFromBooking;
	}
}