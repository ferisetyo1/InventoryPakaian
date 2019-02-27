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
	public partial class editBarang : Form
	{
		public static Boolean editSukses=false;
		public editBarang()
		{
			InitializeComponent();
		}

		private void editBarang_Load(object sender, EventArgs e)
		{
			this.tbNama.Text = ListBarang.nama.ToString();
			this.tbJml.Value = Convert.ToDecimal(ListBarang.jumlah.ToString());
			this.tbHarga.Value= Convert.ToDecimal(ListBarang.harga.ToString());
			Modul Mb = new Modul();
			DataSet Dt1 = Mb.selectJenis();
			DataSet Dt2 = Mb.selectMerk();
			cbJenis.DisplayMember = "Jenis Barang";
			cbJenis.ValueMember = "Jenis Barang";
			cbJenis.DataSource = Dt1.Tables[0];
			cbMerk.DisplayMember = "Nama";
			cbMerk.ValueMember = "Nama";
			cbMerk.DataSource = Dt2.Tables[0];
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			mb.UpdateBarang(ListBarang.id.ToString(), tbNama.Text, cbMerk.GetItemText(cbMerk.SelectedItem), cbJenis.GetItemText(cbJenis.SelectedItem), tbJml.Value, tbHarga.Value);
			editSukses = true;
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
