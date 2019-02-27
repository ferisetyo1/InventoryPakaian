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
	public partial class ListBarang : Form
	{
		public static string id, nama, merk, jenis, jumlah, harga;

		public ListBarang()
		{
			InitializeComponent();
		}

		private void ListBarang_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			this.dataGridView1.DataSource = mb.selectAll("barangtersedia");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			this.dataGridView1.DataSource = mb.Search(textBox1.Text,"nama","barangtersedia");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			editBarang frm = new editBarang();
			DialogResult edit = frm.ShowDialog();
			if (editBarang.editSukses.Equals(true))
			{
				Modul mb = new Modul();
				this.dataGridView1.DataSource = mb.selectAll("barangtersedia");
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				id = row.Cells[0].Value.ToString();
				nama = row.Cells[1].Value.ToString();
				merk = row.Cells[2].Value.ToString();
				jenis = row.Cells[3].Value.ToString();
				jumlah = row.Cells[4].Value.ToString();
				harga = row.Cells[5].Value.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			mb.deleteBarang(id);
			this.dataGridView1.DataSource = mb.selectAll("barangtersedia");
		}

	}
}
