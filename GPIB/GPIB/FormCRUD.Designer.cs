/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 9/1/2019
 * Time: 12:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GPIB
{
	partial class FormCRUD
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.JemaatdataGridView = new System.Windows.Forms.DataGridView();
			this.textCari = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonhelp1 = new System.Windows.Forms.Button();
			this.comboPendidikan = new System.Windows.Forms.ComboBox();
			this.maskedNikah = new System.Windows.Forms.MaskedTextBox();
			this.maskedSidi = new System.Windows.Forms.MaskedTextBox();
			this.maskedBaptis = new System.Windows.Forms.MaskedTextBox();
			this.maskedLahir = new System.Windows.Forms.MaskedTextBox();
			this.btnreset = new System.Windows.Forms.Button();
			this.btncek = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textKwj = new System.Windows.Forms.TextBox();
			this.comboSektor = new System.Windows.Forms.ComboBox();
			this.comboGol = new System.Windows.Forms.ComboBox();
			this.textKet = new System.Windows.Forms.TextBox();
			this.textIns = new System.Windows.Forms.TextBox();
			this.textKerja = new System.Windows.Forms.TextBox();
			this.textNikah = new System.Windows.Forms.TextBox();
			this.textSidi = new System.Windows.Forms.TextBox();
			this.textBaptis = new System.Windows.Forms.TextBox();
			this.textTl = new System.Windows.Forms.TextBox();
			this.textStatus = new System.Windows.Forms.TextBox();
			this.textHk = new System.Windows.Forms.TextBox();
			this.comboJk = new System.Windows.Forms.ComboBox();
			this.textNama = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.btnsimpan = new System.Windows.Forms.Button();
			this.btnedit = new System.Windows.Forms.Button();
			this.btnhapus = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.JemaatdataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// JemaatdataGridView
			// 
			this.JemaatdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.JemaatdataGridView.Location = new System.Drawing.Point(12, 38);
			this.JemaatdataGridView.Name = "JemaatdataGridView";
			this.JemaatdataGridView.Size = new System.Drawing.Size(1049, 455);
			this.JemaatdataGridView.TabIndex = 1;
			this.JemaatdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JemaatdataGridViewCellClick);
			// 
			// textCari
			// 
			this.textCari.Location = new System.Drawing.Point(851, 12);
			this.textCari.Name = "textCari";
			this.textCari.Size = new System.Drawing.Size(210, 20);
			this.textCari.TabIndex = 2;
			this.textCari.TextChanged += new System.EventHandler(this.TextCariTextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonhelp1);
			this.groupBox1.Controls.Add(this.comboPendidikan);
			this.groupBox1.Controls.Add(this.maskedNikah);
			this.groupBox1.Controls.Add(this.maskedSidi);
			this.groupBox1.Controls.Add(this.maskedBaptis);
			this.groupBox1.Controls.Add(this.maskedLahir);
			this.groupBox1.Controls.Add(this.btnreset);
			this.groupBox1.Controls.Add(this.btncek);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.comboStatus);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textKwj);
			this.groupBox1.Controls.Add(this.comboSektor);
			this.groupBox1.Controls.Add(this.comboGol);
			this.groupBox1.Controls.Add(this.textKet);
			this.groupBox1.Controls.Add(this.textIns);
			this.groupBox1.Controls.Add(this.textKerja);
			this.groupBox1.Controls.Add(this.textNikah);
			this.groupBox1.Controls.Add(this.textSidi);
			this.groupBox1.Controls.Add(this.textBaptis);
			this.groupBox1.Controls.Add(this.textTl);
			this.groupBox1.Controls.Add(this.textStatus);
			this.groupBox1.Controls.Add(this.textHk);
			this.groupBox1.Controls.Add(this.comboJk);
			this.groupBox1.Controls.Add(this.textNama);
			this.groupBox1.Location = new System.Drawing.Point(12, 499);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(968, 180);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data";
			// 
			// buttonhelp1
			// 
			this.buttonhelp1.Location = new System.Drawing.Point(644, 16);
			this.buttonhelp1.Name = "buttonhelp1";
			this.buttonhelp1.Size = new System.Drawing.Size(13, 20);
			this.buttonhelp1.TabIndex = 74;
			this.buttonhelp1.Text = "?";
			this.buttonhelp1.UseVisualStyleBackColor = true;
			this.buttonhelp1.Click += new System.EventHandler(this.Buttonhelp1Click);
			// 
			// comboPendidikan
			// 
			this.comboPendidikan.FormattingEnabled = true;
			this.comboPendidikan.Items.AddRange(new object[] {
									"BELUM SEKOLAH",
									"TK",
									"SD",
									"SMP",
									"SMA/SMK",
									"D3",
									"S1",
									"S2",
									"S3"});
			this.comboPendidikan.Location = new System.Drawing.Point(457, 120);
			this.comboPendidikan.Name = "comboPendidikan";
			this.comboPendidikan.Size = new System.Drawing.Size(182, 21);
			this.comboPendidikan.TabIndex = 15;
			// 
			// maskedNikah
			// 
			this.maskedNikah.Location = new System.Drawing.Point(552, 93);
			this.maskedNikah.Mask = "00/00/0000";
			this.maskedNikah.Name = "maskedNikah";
			this.maskedNikah.Size = new System.Drawing.Size(87, 20);
			this.maskedNikah.TabIndex = 14;
			// 
			// maskedSidi
			// 
			this.maskedSidi.Location = new System.Drawing.Point(551, 68);
			this.maskedSidi.Mask = "00/00/0000";
			this.maskedSidi.Name = "maskedSidi";
			this.maskedSidi.Size = new System.Drawing.Size(87, 20);
			this.maskedSidi.TabIndex = 12;
			// 
			// maskedBaptis
			// 
			this.maskedBaptis.Location = new System.Drawing.Point(551, 42);
			this.maskedBaptis.Mask = "00/00/0000";
			this.maskedBaptis.Name = "maskedBaptis";
			this.maskedBaptis.Size = new System.Drawing.Size(87, 20);
			this.maskedBaptis.TabIndex = 10;
			// 
			// maskedLahir
			// 
			this.maskedLahir.Location = new System.Drawing.Point(551, 16);
			this.maskedLahir.Mask = "00/00/0000";
			this.maskedLahir.Name = "maskedLahir";
			this.maskedLahir.Size = new System.Drawing.Size(87, 20);
			this.maskedLahir.TabIndex = 8;
			// 
			// btnreset
			// 
			this.btnreset.Location = new System.Drawing.Point(801, 142);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(75, 23);
			this.btnreset.TabIndex = 73;
			this.btnreset.Text = "Reset";
			this.btnreset.UseVisualStyleBackColor = true;
			this.btnreset.Click += new System.EventHandler(this.BtnresetClick);
			// 
			// btncek
			// 
			this.btncek.Location = new System.Drawing.Point(882, 142);
			this.btncek.Name = "btncek";
			this.btncek.Size = new System.Drawing.Size(75, 23);
			this.btncek.TabIndex = 72;
			this.btncek.Text = "Cek";
			this.btncek.UseVisualStyleBackColor = true;
			this.btncek.Click += new System.EventHandler(this.BtncekClick);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(663, 67);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 71;
			this.label17.Text = "Pelkat";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(6, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 70;
			this.label16.Text = "Sektor";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboStatus
			// 
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Items.AddRange(new object[] {
									"PA",
									"PT",
									"GP",
									"PKP",
									"PKB",
									"PKLU"});
			this.comboStatus.Location = new System.Drawing.Point(775, 69);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(182, 21);
			this.comboStatus.TabIndex = 19;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(663, 93);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 68;
			this.label15.Text = "Keterangan";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(663, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 67;
			this.label14.Text = "Golongan Darah";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(663, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 20);
			this.label13.TabIndex = 66;
			this.label13.Text = "Nama Instansi";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(316, 145);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 20);
			this.label12.TabIndex = 65;
			this.label12.Text = "Pekerjaan";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(316, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(102, 20);
			this.label11.TabIndex = 64;
			this.label11.Text = "Pendidikan Terakhir";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(316, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(133, 23);
			this.label10.TabIndex = 63;
			this.label10.Text = "Gereja dan Tanggal Nikah";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(316, 68);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 23);
			this.label9.TabIndex = 62;
			this.label9.Text = "Gereja dan Tanggal Sidi";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(316, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 23);
			this.label8.TabIndex = 61;
			this.label8.Text = "Gereja dan Tanggal Baptis";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(316, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 20);
			this.label6.TabIndex = 59;
			this.label6.Text = "Tempat dan Tanggal Lahir";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(5, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 20);
			this.label5.TabIndex = 58;
			this.label5.Text = "Status";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 57;
			this.label4.Text = "Hubungan Keluarga";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 21);
			this.label3.TabIndex = 56;
			this.label3.Text = "Jenis Kelamin";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 55;
			this.label2.Text = "Nama Lengkap";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(6, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 54;
			this.label1.Text = "Nomor KWJ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textKwj
			// 
			this.textKwj.Location = new System.Drawing.Point(115, 43);
			this.textKwj.Name = "textKwj";
			this.textKwj.Size = new System.Drawing.Size(182, 20);
			this.textKwj.TabIndex = 2;
			// 
			// comboSektor
			// 
			this.comboSektor.FormattingEnabled = true;
			this.comboSektor.Items.AddRange(new object[] {
									"Sektor I",
									"Sektor II",
									"Sektor III"});
			this.comboSektor.Location = new System.Drawing.Point(115, 16);
			this.comboSektor.Name = "comboSektor";
			this.comboSektor.Size = new System.Drawing.Size(182, 21);
			this.comboSektor.TabIndex = 1;
			// 
			// comboGol
			// 
			this.comboGol.FormattingEnabled = true;
			this.comboGol.Items.AddRange(new object[] {
									"A",
									"B",
									"O",
									"AB"});
			this.comboGol.Location = new System.Drawing.Point(775, 42);
			this.comboGol.Name = "comboGol";
			this.comboGol.Size = new System.Drawing.Size(182, 21);
			this.comboGol.TabIndex = 18;
			// 
			// textKet
			// 
			this.textKet.Location = new System.Drawing.Point(775, 96);
			this.textKet.Name = "textKet";
			this.textKet.Size = new System.Drawing.Size(182, 20);
			this.textKet.TabIndex = 20;
			// 
			// textIns
			// 
			this.textIns.Location = new System.Drawing.Point(775, 16);
			this.textIns.Name = "textIns";
			this.textIns.Size = new System.Drawing.Size(182, 20);
			this.textIns.TabIndex = 17;
			// 
			// textKerja
			// 
			this.textKerja.Location = new System.Drawing.Point(457, 147);
			this.textKerja.Name = "textKerja";
			this.textKerja.Size = new System.Drawing.Size(182, 20);
			this.textKerja.TabIndex = 16;
			// 
			// textNikah
			// 
			this.textNikah.Location = new System.Drawing.Point(457, 94);
			this.textNikah.Name = "textNikah";
			this.textNikah.Size = new System.Drawing.Size(88, 20);
			this.textNikah.TabIndex = 13;
			// 
			// textSidi
			// 
			this.textSidi.Location = new System.Drawing.Point(457, 68);
			this.textSidi.Name = "textSidi";
			this.textSidi.Size = new System.Drawing.Size(88, 20);
			this.textSidi.TabIndex = 11;
			// 
			// textBaptis
			// 
			this.textBaptis.Location = new System.Drawing.Point(457, 42);
			this.textBaptis.Name = "textBaptis";
			this.textBaptis.Size = new System.Drawing.Size(88, 20);
			this.textBaptis.TabIndex = 9;
			// 
			// textTl
			// 
			this.textTl.Location = new System.Drawing.Point(457, 16);
			this.textTl.Name = "textTl";
			this.textTl.Size = new System.Drawing.Size(88, 20);
			this.textTl.TabIndex = 7;
			// 
			// textStatus
			// 
			this.textStatus.Location = new System.Drawing.Point(115, 148);
			this.textStatus.Name = "textStatus";
			this.textStatus.Size = new System.Drawing.Size(182, 20);
			this.textStatus.TabIndex = 6;
			// 
			// textHk
			// 
			this.textHk.Location = new System.Drawing.Point(115, 122);
			this.textHk.Name = "textHk";
			this.textHk.Size = new System.Drawing.Size(182, 20);
			this.textHk.TabIndex = 5;
			// 
			// comboJk
			// 
			this.comboJk.FormattingEnabled = true;
			this.comboJk.Items.AddRange(new object[] {
									"Laki-laki",
									"Perempuan"});
			this.comboJk.Location = new System.Drawing.Point(115, 95);
			this.comboJk.Name = "comboJk";
			this.comboJk.Size = new System.Drawing.Size(182, 21);
			this.comboJk.TabIndex = 4;
			// 
			// textNama
			// 
			this.textNama.Location = new System.Drawing.Point(115, 69);
			this.textNama.Name = "textNama";
			this.textNama.Size = new System.Drawing.Size(182, 20);
			this.textNama.TabIndex = 3;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(820, 12);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(25, 23);
			this.label18.TabIndex = 4;
			this.label18.Text = "Cari";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnsimpan
			// 
			this.btnsimpan.Location = new System.Drawing.Point(986, 513);
			this.btnsimpan.Name = "btnsimpan";
			this.btnsimpan.Size = new System.Drawing.Size(75, 23);
			this.btnsimpan.TabIndex = 73;
			this.btnsimpan.Text = "Simpan";
			this.btnsimpan.UseVisualStyleBackColor = true;
			this.btnsimpan.Click += new System.EventHandler(this.BtnsimpanClick);
			// 
			// btnedit
			// 
			this.btnedit.Location = new System.Drawing.Point(986, 542);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(75, 23);
			this.btnedit.TabIndex = 74;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = true;
			this.btnedit.Click += new System.EventHandler(this.BtneditClick);
			// 
			// btnhapus
			// 
			this.btnhapus.Location = new System.Drawing.Point(986, 571);
			this.btnhapus.Name = "btnhapus";
			this.btnhapus.Size = new System.Drawing.Size(75, 23);
			this.btnhapus.TabIndex = 75;
			this.btnhapus.Text = "Hapus";
			this.btnhapus.UseVisualStyleBackColor = true;
			this.btnhapus.Click += new System.EventHandler(this.BtnhapusClick);
			// 
			// FormCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 691);
			this.Controls.Add(this.btnhapus);
			this.Controls.Add(this.btnedit);
			this.Controls.Add(this.btnsimpan);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textCari);
			this.Controls.Add(this.JemaatdataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCRUD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormCRUD";
			this.Load += new System.EventHandler(this.FormCRUDLoad);
			((System.ComponentModel.ISupportInitialize)(this.JemaatdataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonhelp1;
		private System.Windows.Forms.ComboBox comboPendidikan;
		private System.Windows.Forms.MaskedTextBox maskedBaptis;
		private System.Windows.Forms.MaskedTextBox maskedSidi;
		private System.Windows.Forms.MaskedTextBox maskedNikah;
		private System.Windows.Forms.MaskedTextBox maskedLahir;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.Button btnhapus;
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.Button btnsimpan;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button btncek;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textKwj;
		private System.Windows.Forms.ComboBox comboSektor;
		private System.Windows.Forms.ComboBox comboGol;
		private System.Windows.Forms.TextBox textKet;
		private System.Windows.Forms.TextBox textIns;
		private System.Windows.Forms.TextBox textKerja;
		private System.Windows.Forms.TextBox textNikah;
		private System.Windows.Forms.TextBox textSidi;
		private System.Windows.Forms.TextBox textBaptis;
		private System.Windows.Forms.TextBox textTl;
		private System.Windows.Forms.TextBox textStatus;
		private System.Windows.Forms.TextBox textHk;
		private System.Windows.Forms.TextBox textNama;
		private System.Windows.Forms.TextBox textCari;
		private System.Windows.Forms.DataGridView JemaatdataGridView;
		private System.Windows.Forms.ComboBox comboJk;
	}
}
