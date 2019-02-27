using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectUTS
{
	class Modul
	{
		private string server;
		private string database;
		private string uid;
		private string password;
		private MySqlConnection connection;

		public Modul()
		{
			Initialize();
		}

		private void Initialize()
		{
			server = "localhost";
			database = "penyimpanan";
			uid = "root";
			password = "12345678";
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" +
			database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";sslMode=none";

			connection = new MySqlConnection(connectionString);
		}

		private bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
					case 0:
						MessageBox.Show("Tidak bisa mengkoneksikan ke server");
						break;

					case 1045:
						MessageBox.Show("Salah username/password database");
						break;
				}
				return false;
			}
		}

		private bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		//barang
		public int getJumlahBarang(string nama)
		{
			int jml=0;
			string query = "SELECT `Jumlah Barang` FROM `barangtersedia` WHERE `Nama`=\'" + nama + "\'";
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				object result = cmd.ExecuteScalar();
				if (result != null)
					jml = Convert.ToInt32(result);
				this.CloseConnection();
			}
			return jml;
		}

		public void setJumlahBarang(int jml,string nama)
		{
			string query= "UPDATE `barangtersedia` SET `Jumlah Barang`=\'"+jml+ "\' WHERE `Nama`=\'"+nama+"\'";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void InsertBarang(String Nama, String Merk, String Jenis, decimal Jml, decimal Harga)
		{
			string query = "INSERT INTO `barangtersedia` (`Nama`, `Merk`, `Jenis Barang`, `Jumlah Barang`, `Harga Barang`) VALUES (\'" + Nama+ "\',\'" + Merk+ "\',\'" + Jenis+ "\',\'" + Jml+ "\',\'" + Harga+ "\');";
			if (this.OpenConnection() == true)
			{
				try
				{
					
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input barang");
					
				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void insertBarangMasuk(String nama, decimal jml, string tanggal)
		{
			string query = "INSERT INTO `barangmasuk` (`Nama`, `Jumlah Barang`, `Tanggal`, `user`) VALUES (\'" + nama + "\',\'" + jml + "\',\'" + tanggal + "\',\'" + FormLogin.login.ToString() + "\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input barang");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void insertBarangKeluar(String nama,string mitra, decimal jml, string tanggal)
		{
			string query = "INSERT INTO `barangkeluar` (`Nama`, `Mitra`, `Jumlah Barang`, `Tanggal`, `user`) VALUES (\'" + nama + "\',\'" + mitra + "\',\'" + jml + "\',\'" + tanggal + "\',\'" + FormLogin.login.ToString() + "\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input barang");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void UpdateBarang(String Id, String Nama, String Merk, String Jenis, decimal Jml, decimal Harga)
		{
			string query = "UPDATE `barangtersedia` SET `Nama`=\'" + Nama + "\',`Merk`=\'" + Merk + "\',`Jenis Barang`=\'" + Jenis + "\',`Jumlah Barang`=\'" + Jml + "\',`Harga Barang`=\'" + Harga + "\' WHERE id=\'" + Id + "\'";

			if (this.OpenConnection() == true)
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();
					this.CloseConnection();

					MessageBox.Show("Sukses mengganti data barang");
				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void deleteBarang(String id)
		{
			string query = "DELETE FROM barangtersedia WHERE id=\'" + id + "\'";

			if (this.OpenConnection() == true)
			{
				DialogResult dr = MessageBox.Show("Are you sure?",
					  "Delete", MessageBoxButtons.YesNo);
				if (dr == DialogResult.Yes)
				{
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();
				}
				this.CloseConnection();
			}
		}

		public DataSet selectNamaBarang()
		{
			string query = "SELECT `Nama` FROM `barangtersedia`";

			DataSet dt = new DataSet();

			//Open connection
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter
				{
					SelectCommand = cmd
				};
				MyAdapter.Fill(dt);
				this.CloseConnection();

				return dt;
			}
			else
			{
				return dt;
			}
		}

		//user
		public void InsertUser(string username,string password)
		{
			string query = "INSERT INTO `user` (`username`, `password`) VALUES (\'" + username + "\',\'" + password + "\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input barang");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		//jenisBarang
		public void InsertJenisBarang(string jenis)
		{
			string query = "INSERT INTO `jenisbarang` (`Jenis Barang`) VALUES (\'" + jenis + "\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input barang");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public DataSet selectJenis()
		{
			string query = "SELECT `Jenis Barang` FROM `jenisbarang`";

			DataSet dt = new DataSet();

			//Open connection
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter
				{
					SelectCommand = cmd
				};
				MyAdapter.Fill(dt);
				this.CloseConnection();

				return dt;
			}
			else
			{
				return dt;
			}
		}


		//supplier
		public DataSet selectMerk()
		{
			string query = "SELECT `Nama` FROM `supplier`";

			DataSet dt = new DataSet();

			//Open connection
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter
				{
					SelectCommand = cmd
				};
				MyAdapter.Fill(dt);
				this.CloseConnection();

				return dt;
			}
			else
			{
				return dt;
			}
		}

		public void InsertSupplier(string nama, string alamat, string telp)
		{
			string query = "INSERT INTO `supplier` ( `Nama`, `Alamat`, `No. Telepon`) VALUES (\'" + nama + "\',\'" + alamat + "\',\'" + telp + "\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input data supplier");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		//mitra
		public DataSet selectMitra()
		{
			string query = "SELECT `Nama` FROM `mitra`";

			DataSet dt = new DataSet();

			//Open connection
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter
				{
					SelectCommand = cmd
				};
				MyAdapter.Fill(dt);
				this.CloseConnection();

				return dt;
			}
			else
			{
				return dt;
			}
		}

		public void InsertMitra(string nama, string alamat, string telp)
		{
			string query = "INSERT INTO `Mitra` ( `Nama`, `Alamat`, `No. Telepon`) VALUES (\'" + nama + "\',\'" + alamat + "\',\'" + telp + "\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Sukses input data mitra");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		//umum
		public DataTable selectAll(string namaTabel)
		{
			string query = "SELECT * FROM `"+namaTabel+"`";

			DataTable dt = new DataTable();

			//Open connection
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter
				{
					SelectCommand = cmd
				};
				MyAdapter.Fill(dt);
				this.CloseConnection();

				return dt;
			}
			else
			{
				return dt;
			}
		}

		public DataTable Search(string text,string namakolum,string namatabel)
		{
			string query = "SELECT * FROM "+namatabel+" Where "+namakolum+" LIKE \'%" + text + "%\'";

			DataTable dt = new DataTable();

			//Open connection
			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataAdapter MyAdapter = new MySqlDataAdapter
				{
					SelectCommand = cmd
				};
				MyAdapter.Fill(dt);
				this.CloseConnection();

				return dt;
			}
			else
			{
				return dt;
			}

		}

		public void konfirmasiBarangmasuk(string nama, string jml, string user, string tanggal)
		{
			string query = "INSERT INTO `Laporan` ( `Nama`, `Jumlah Barang`, `user`, `Tanggal`, `Keterangan` ) VALUES (\'" + nama + "\',\'" + jml + "\',\'" + user + "\',\'" + tanggal + "\',\'Barang masuk sudah dikonfirmasi admin\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Laporan telah dibuat");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void konfirmasiBarangkeluar(string nama, string mitra, string jml, string user, string tanggal)
		{
			string query = "INSERT INTO `Laporan` ( `Nama`,`Mitra`, `Jumlah Barang`, `user`, `Tanggal`, `Keterangan` ) VALUES (\'" + nama + "\',\'" + mitra + "\',\'" + jml + "\',\'" + user + "\',\'" + tanggal + "\',\'Barang keluar sudah dikonfirmasi admin\');";
			if (this.OpenConnection() == true)
			{
				try
				{

					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.ExecuteNonQuery();

					this.CloseConnection();

					MessageBox.Show("Laporan telah dibuat");

				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void deleteBarangKeluar(String id)
		{
			string query = "DELETE FROM barangkeluar WHERE id=\'" + id + "\'";

			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				this.CloseConnection();
			}
		}

		public void deleteBarangMasuk(String id)
		{
			string query = "DELETE FROM barangmasuk WHERE id=\'" + id + "\'";

			if (this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				this.CloseConnection();
			}
		}
	}
}
