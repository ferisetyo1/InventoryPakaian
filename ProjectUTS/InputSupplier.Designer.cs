namespace ProjectUTS
{
	partial class InputSupplier
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
			this.tbNama = new System.Windows.Forms.TextBox();
			this.tbAlamat = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTelp = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(168, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(204, 25);
			this.label5.TabIndex = 3;
			this.label5.Text = "Input Supplier Baru";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.tbNama);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.tbAlamat);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.tbTelp);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.btSubmit);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(78, 73);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 119);
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
			this.btSubmit.Location = new System.Drawing.Point(95, 81);
			this.btSubmit.Name = "btSubmit";
			this.btSubmit.Size = new System.Drawing.Size(247, 23);
			this.btSubmit.TabIndex = 10;
			this.btSubmit.Text = "Submit";
			this.btSubmit.UseVisualStyleBackColor = false;
			this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
			// 
			// tbNama
			// 
			this.tbNama.Location = new System.Drawing.Point(95, 3);
			this.tbNama.Name = "tbNama";
			this.tbNama.Size = new System.Drawing.Size(247, 20);
			this.tbNama.TabIndex = 0;
			// 
			// tbAlamat
			// 
			this.tbAlamat.Location = new System.Drawing.Point(95, 29);
			this.tbAlamat.Name = "tbAlamat";
			this.tbAlamat.Size = new System.Drawing.Size(247, 20);
			this.tbAlamat.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Alamat";
			// 
			// tbTelp
			// 
			this.tbTelp.Location = new System.Drawing.Point(95, 55);
			this.tbTelp.Name = "tbTelp";
			this.tbTelp.Size = new System.Drawing.Size(247, 20);
			this.tbTelp.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "No. Telepon";
			// 
			// InputSupplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(500, 231);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "InputSupplier";
			this.Text = "InputSupplier";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox tbNama;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbAlamat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTelp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btSubmit;
	}
}