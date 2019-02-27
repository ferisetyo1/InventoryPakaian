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
	public partial class InputSupplier : Form
	{
		public InputSupplier()
		{
			InitializeComponent();
		}

		private void btSubmit_Click(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			mb.InsertSupplier(tbNama.Text, tbAlamat.Text, tbTelp.Text);
		}
	}
}
