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
	public partial class InputBarangMasuk : Form
	{
		public InputBarangMasuk()
		{
			InitializeComponent();
		}

		private void InputBarangMasuk_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			DataSet dt = mb.selectNamaBarang();
			cbNama.DisplayMember = "Nama";
			cbNama.ValueMember = "Nama";
			cbNama.DataSource = dt.Tables[0];
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			DateTime dateValue = dateTimePicker1.Value;
			string date = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
			Modul mb = new Modul();
			mb.insertBarangMasuk(cbNama.GetItemText(cbNama.SelectedItem), tbJml.Value, date);
		}
	}
}
