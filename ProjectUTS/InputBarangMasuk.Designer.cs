namespace ProjectUTS
{
	partial class InputBarangMasuk
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label5 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.btSubmit = new System.Windows.Forms.Button();
			this.cbNama = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbJml = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbJml)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(153, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(217, 25);
			this.label5.TabIndex = 3;
			this.label5.Text = "Input Barang Masuk";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cbNama);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.tbJml);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.btSubmit);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(63, 69);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 122);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nama";
			// 
			// btSubmit
			// 
			this.btSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.btSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSubmit.FlatAppearance.BorderSize = 0;
			this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSubmit.ForeColor = System.Drawing.SystemColors.Control;
			this.btSubmit.Location = new System.Drawing.Point(95, 82);
			this.btSubmit.Name = "btSubmit";
			this.btSubmit.Size = new System.Drawing.Size(247, 23);
			this.btSubmit.TabIndex = 10;
			this.btSubmit.Text = "Submit";
			this.btSubmit.UseVisualStyleBackColor = false;
			this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
			// 
			// cbNama
			// 
			this.cbNama.FormattingEnabled = true;
			this.cbNama.Location = new System.Drawing.Point(95, 3);
			this.cbNama.Name = "cbNama";
			this.cbNama.Size = new System.Drawing.Size(247, 21);
			this.cbNama.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Jumlah Barang";
			// 
			// tbJml
			// 
			this.tbJml.Location = new System.Drawing.Point(95, 30);
			this.tbJml.Name = "tbJml";
			this.tbJml.Size = new System.Drawing.Size(247, 20);
			this.tbJml.TabIndex = 4;
			this.tbJml.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Tanggal";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(95, 56);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
			this.dateTimePicker1.TabIndex = 17;
			// 
			// InputBarangMasuk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(500, 217);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InputBarangMasuk";
			this.Text = "InputBarangMasuk";
			this.Load += new System.EventHandler(this.InputBarangMasuk_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbJml)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btSubmit;
		private System.Windows.Forms.ComboBox cbNama;
		private System.Windows.Forms.NumericUpDown tbJml;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
	}
}