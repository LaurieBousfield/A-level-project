using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCreation
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void btnFrmBooking_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmBooking frmBooking = new FrmBooking();
			frmBooking.ShowDialog();
		}

		private void btnFrmDatabaseCreation_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmDatabaseCreation FrmDatabaseCreation = new FrmDatabaseCreation();
			FrmDatabaseCreation.ShowDialog();
		}
	}
}
