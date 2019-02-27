using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUTS
{
	public partial class FormLogin : Form
	{
		String adminUser = "admin";
		String adminPassword = "admin";
		public static string login;

		public FormLogin()
		{
			InitializeComponent();
		}

		private void btLogin_Click(object sender, EventArgs e)
		{
			login = tbUsername.Text;
			if (tbUsername.Text == this.adminUser && tbPassword.Text == this.adminPassword)
			{
				this.Hide();
				MainAppAdmin frm = new MainAppAdmin();
				frm.ShowDialog();
				this.Close();
			}else if(statusLoginUser(tbUsername.Text, tbPassword.Text)==true)
			{
				this.Hide();
				MainAppUser frm = new MainAppUser();
				frm.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("username atau password salah");
			}
		}

		public bool statusLoginUser(string username, string password)
		{
			bool status = false;
			Modul mb = new Modul();
			DataTable dt = mb.selectAll("user");
			foreach (DataRow dr in dt.Rows)
			{
				if (dr[1].ToString() == username && dr[2].ToString() == password)
				{
					status = true;
					break;
				}
			}
			return status;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
