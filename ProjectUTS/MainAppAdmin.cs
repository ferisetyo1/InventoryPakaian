using System;
using System.Windows.Forms;

namespace ProjectUTS
{
	public partial class MainAppAdmin : Form
	{
		public MainAppAdmin()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void inBarang_Click(object sender, EventArgs e)
		{
			InputBarangBaru frm = new InputBarangBaru();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0) {
				this.panel4.Controls.Clear();
			} ;
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void showBarang_Click(object sender, EventArgs e)
		{
			ListBarang frm = new ListBarang();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if ("Input                             ▾" == button1.Text)
			{
				button1.Text = "Input                             ▴";
				panel6.Height = 216;
			}
			else
			{
				button1.Text = "Input                             ▾";
				panel6.Height = 0;
			}
		}

		private void MainApp_Load(object sender, EventArgs e)
		{
			flowLayoutPanel1.AutoScroll = false;
			flowLayoutPanel1.HorizontalScroll.Enabled = false;
			flowLayoutPanel1.HorizontalScroll.Visible = false;
			flowLayoutPanel1.HorizontalScroll.Maximum = 0;
			flowLayoutPanel1.AutoScroll = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if ("List                                 ▾" == button2.Text)
			{
				button2.Text = "List                                 ▴";
				panel5.Height = 177;
			}
			else
			{
				button2.Text = "List                                 ▾";
				panel5.Height = 0;
			}
		}

		private void showUser_Click(object sender, EventArgs e)
		{
			ListUser frm = new ListUser();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void showMitra_Click(object sender, EventArgs e)
		{
			ListMitra frm = new ListMitra();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void showSupplier_Click(object sender, EventArgs e)
		{
			ListSupplier frm = new ListSupplier();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void inUser_Click(object sender, EventArgs e)
		{
			InputUser frm = new InputUser();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void inJenisBarang_Click(object sender, EventArgs e)
		{
			InputJenisBarang frm = new InputJenisBarang();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void inMitra_Click(object sender, EventArgs e)
		{
			InputMitra frm = new InputMitra();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void inSupplier_Click(object sender, EventArgs e)
		{
			InputSupplier frm = new InputSupplier();
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

		private void button5_Click(object sender, EventArgs e)
		{
			KonfrmBarangMasuk frm = new KonfrmBarangMasuk();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			KonfrmBarangKeluar frm = new KonfrmBarangKeluar();
			frm.TopLevel = false;
			frm.AutoScroll = true;
			if (this.panel4.Controls.Count > 0)
			{
				this.panel4.Controls.Clear();
			};
			this.panel4.Controls.Add(frm);
			frm.Show();
		}

		private void button7_Click(object sender, EventArgs e)
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
