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
	public partial class Laporan : Form
	{
		public Laporan()
		{
			InitializeComponent();
		}

		private void Laporan_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.selectAll("laporan");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.Search(textBox1.Text,"nama","laporan");
		}
	}
}
