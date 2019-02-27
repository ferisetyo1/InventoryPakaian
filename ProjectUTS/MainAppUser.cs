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
	public partial class MainAppUser : Form
	{
		public MainAppUser()
		{
			InitializeComponent();
		}

		private void MainAppUser_Load(object sender, EventArgs e)
		{
			label1.Text = "Welcome, " + FormLogin.login.ToString() + "!";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void InBarangMasuk_Click(object sender, EventArgs e)
		{
			InputBarangMasuk frm = new InputBarangMasuk();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void inBarangKeluar_Click(object sender, EventArgs e)
		{
			InputBarangKeluar frm = new InputBarangKeluar();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void logout_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormLogin frm = new FormLogin();
			FormLogin.login = "";
			frm.ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ReqBarangMasuk frm = new ReqBarangMasuk();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ReqBarangKeluar frm = new ReqBarangKeluar();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Laporan frm = new Laporan();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}
	}
}
