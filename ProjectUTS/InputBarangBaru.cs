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
	public partial class InputBarangBaru : Form
	{
		public InputBarangBaru()
		{
			InitializeComponent();
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			Modul Mb = new Modul();
			Mb.InsertBarang(tbNama.Text, cbMerk.GetItemText(cbMerk.SelectedItem), cbJenis.GetItemText(cbJenis.SelectedItem), tbJml.Value, tbHarga.Value);
		}

		private void FormInput_Load(object sender, EventArgs e)
		{
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
	}
}
