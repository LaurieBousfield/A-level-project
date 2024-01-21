using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DatabaseCreation
{
	public partial class FrmLogin : Form
	{

		private const string Username = "Tobie Jennings";
		private const string Password = "Laurie12";
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			txtLUserName.Text = "Tobie Jennings";
			txtLPassword.Text = "Laurie12";
		}

		public bool ValidCredentials(string userName, string password)
		{
			if ((userName == Username) && (password == Password))
			{
				
				return true;
			}
			else
			{
				return false;
			}

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			lbLIncorrect.Visible = false;
			string userNameEntry = txtLUserName.Text;
			string passwordEntry = txtLPassword.Text;

			if (ValidCredentials(userNameEntry, passwordEntry))
			{
				this.Hide();
				FrmMenu Menu = new FrmMenu();
				Menu.ShowDialog();
			}
			else
			{
				txtLUserName.Text = "";
				txtLPassword.Text = "";
			}

			lbLIncorrect.Visible = true;
		}

		

		private void pnlMenu_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
