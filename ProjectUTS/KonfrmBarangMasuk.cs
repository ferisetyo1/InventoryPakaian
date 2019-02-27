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
	public partial class KonfrmBarangMasuk : Form
	{
		string id, nama, jml, user;
		DateTime tanggal;

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				id = row.Cells[0].Value.ToString();
				nama = row.Cells[1].Value.ToString();
				jml = row.Cells[2].Value.ToString();
				tanggal = Convert.ToDateTime(row.Cells[3].Value.ToString());
				user = row.Cells[4].Value.ToString();
			}
		}

		public KonfrmBarangMasuk()
		{
			InitializeComponent();
		}

		private void KonfrmBarangMasuk_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.selectAll("barangmasuk");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.Search(textBox1.Text,"nama","barangmasuk");
		}

		private void Konfirmasi_Click(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			string date = tanggal.ToString("yyyy-MM-dd HH:mm:ss");
			DialogResult dr= MessageBox.Show("Are you sure?",
					  "Confirmation", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				mb.konfirmasiBarangmasuk(this.nama, this.jml, this.user, date);
				int jmlbarangtersedia = mb.getJumlahBarang(this.nama);
				int jmlbaru = jmlbarangtersedia + Convert.ToInt32(this.jml);
				mb.setJumlahBarang(jmlbaru,this.nama);
				mb.deleteBarangMasuk(this.id);
			}
			dataGridView1.DataSource = mb.selectAll("barangkeluar");
		}
	}
}
