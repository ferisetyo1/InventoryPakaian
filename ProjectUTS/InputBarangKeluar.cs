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
	public partial class InputBarangKeluar : Form
	{
		public InputBarangKeluar()
		{
			InitializeComponent();
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			DateTime dateValue = dateTimePicker1.Value;
			string date = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
			Modul mb = new Modul();
			mb.insertBarangKeluar(cbNama.GetItemText(cbNama.SelectedItem), cbMitra.GetItemText(cbMitra.SelectedItem), tbJml.Value, date);
		}

		private void InputBarangKeluar_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			DataSet dt1 = mb.selectNamaBarang();
			DataSet dt2 = mb.selectMitra();
			cbNama.DisplayMember = "Nama";
			cbNama.ValueMember = "Nama";
			cbNama.DataSource = dt1.Tables[0];
			cbMitra.DisplayMember = "Nama";
			cbMitra.ValueMember = "Nama";
			cbMitra.DataSource = dt2.Tables[0];

		}
	}
}
