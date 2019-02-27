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
	public partial class ListUser : Form
	{
		public ListUser()
		{
			InitializeComponent();
		}

		private void ListUser_Load(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.selectAll("user");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Modul mb = new Modul();
			dataGridView1.DataSource = mb.Search(textBox1.Text,"username","user");
		}
	}
}
