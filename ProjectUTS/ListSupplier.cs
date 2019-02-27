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
	public partial class ListSupplier : Form
	{
		public ListSupplier()
		{
			InitializeComponent();
		}

		private void ListSupplier_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.selectAll("supplier");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.Search(textBox1.Text, "nama", "suppplier");
		}
	}
}
