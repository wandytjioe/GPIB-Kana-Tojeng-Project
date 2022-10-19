/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 9/1/2019
 * Time: 12:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace GPIB
{
	/// <summary>
	/// Description of FormCRUD.
	/// </summary>
	public partial class FormCRUD : Form
	{
		public FormCRUD()
		{
			InitializeComponent();
		}
		
		MySqlConnection con = connectionService.getConnection();
		public int id;
		
		//Data
		private void GetTbgpib()
		{
			MySqlCommand cmd = new MySqlCommand ("SELECT * from tbgpib", con);
			DataTable dt = new DataTable();
			
			con.Open();
			
			MySqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();
			
			JemaatdataGridView.DataSource = dt;
		}
		
		//MainView
		void FormCRUDLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			comboSektor.SelectedItem = "Sektor I";
			comboGol.DropDownStyle = ComboBoxStyle.DropDownList;
			comboJk.DropDownStyle = ComboBoxStyle.DropDownList;
			comboSektor.DropDownStyle = ComboBoxStyle.DropDownList;
			comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			comboPendidikan.DropDownStyle = ComboBoxStyle.DropDownList;

			JemaatdataGridView.AllowUserToAddRows = false;
    		JemaatdataGridView.AllowUserToDeleteRows = false;
    		JemaatdataGridView.AllowUserToOrderColumns = true;
    		JemaatdataGridView.ReadOnly = true;
    		JemaatdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    		JemaatdataGridView.MultiSelect = false;
    		JemaatdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		JemaatdataGridView.AllowUserToResizeColumns = false;
    		JemaatdataGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		JemaatdataGridView.AllowUserToResizeRows = false;
    		JemaatdataGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
   			
   			textKwj.Select();
   			textKwj.Focus();
		}
		
		//ListComboSektor
		void isiSektor()
		{
			comboSektor.Items.Add("Sektor I");
			comboSektor.Items.Add("Sektor II");
			comboSektor.Items.Add("Sektor III");
		}
		
		//ListCombojk
		void isiJk()
		{
			comboJk.Items.Add("Laki-Laki");
			comboJk.Items.Add("Perempuan");
		}
		
		//ListGol
		void isiGol()
		{
			comboGol.Items.Add("A");
			comboGol.Items.Add("B");
			comboGol.Items.Add("O");
			comboGol.Items.Add("AB");
		}
		
		//ListStatusGereja
		void isiStatusGereja()
		{
			comboStatus.Items.Add("PA");
			comboStatus.Items.Add("PT");
			comboStatus.Items.Add("GP");
			comboStatus.Items.Add("PKP");
			comboStatus.Items.Add("PKB");
			comboStatus.Items.Add("PKLU");
		}
		
		void isiPendidikan()
		{
			comboPendidikan.Items.Add("TK");
			comboPendidikan.Items.Add("SD");
			comboPendidikan.Items.Add("SMP");
			comboPendidikan.Items.Add("SMA/SMK");
			comboPendidikan.Items.Add("D3");
			comboPendidikan.Items.Add("S1");
			comboPendidikan.Items.Add("S2");
			comboPendidikan.Items.Add("S3");
		}
		
		//Else
		private bool IsValid()
		{
			if (textKwj.Text == string.Empty || textNama.Text == string.Empty || comboJk.Text == string.Empty || textHk.Text == string.Empty || textStatus.Text == string.Empty || textTl.Text == string.Empty || maskedLahir.Text == string.Empty || textBaptis.Text == string.Empty || maskedBaptis.Text == string.Empty || textSidi.Text == string.Empty || maskedSidi.Text == string.Empty || textNikah.Text == string.Empty || maskedNikah.Text == string.Empty || comboPendidikan.Text == string.Empty || textKerja.Text == string.Empty || textIns.Text == string.Empty || comboGol.Text == string.Empty || comboStatus.Text == string.Empty || textKet.Text == string.Empty)
			{
				MessageBox.Show("Semua wajib diisi", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (id > 0 || textKwj.Text == string.Empty || textNama.Text == string.Empty || comboJk.Text == string.Empty || textHk.Text == string.Empty || textStatus.Text == string.Empty || textTl.Text == string.Empty || maskedLahir.Text == string.Empty || textBaptis.Text == string.Empty || maskedBaptis.Text == string.Empty || textSidi.Text == string.Empty || maskedSidi.Text == string.Empty || textNikah.Text == string.Empty || maskedNikah.Text == string.Empty || comboPendidikan.Text == string.Empty || textKerja.Text == string.Empty || textIns.Text == string.Empty || comboGol.Text == string.Empty || comboStatus.Text == string.Empty || textKet.Text == string.Empty)
			{
				MessageBox.Show("Klik tombol reset kemudian isi data manual", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;	
			}
			return true;
		}
		
		//Reset All
		void reset()
		{
			id = 0;
			textKwj.Clear();
			textNama.Clear();
			comboJk.SelectedItem = null;
			textHk.Clear();
			textStatus.Clear();
			textTl.Clear();
			maskedLahir.Text = null;
			textBaptis.Clear();
			maskedBaptis.Text = null;
			textSidi.Clear();
			maskedSidi.Text = null;
			textNikah.Clear();
			maskedNikah.Text = null;
			comboPendidikan.SelectedItem = null;
			textKerja.Clear();
			textIns.Clear();
			comboGol.SelectedItem = null;
			comboStatus.SelectedItem = null;
			textKet.Clear();
			
			textKwj.Select();
			textKwj.Focus();
		}
		
		//Simpan
		void BtnsimpanClick(object sender, EventArgs e)
		{
			//Simpan ke SI
			if (IsValid())
			{
				MySqlCommand cmd = new MySqlCommand ("INSERT INTO tbgpib VALUES (NULL, @Sektor, @NoKwj, @NamaLengkap, @JenisKelamin, @HubunganKeluarga, @Status, @TempatLahir, @TanggalLahir, @GerejaBaptis, @TanggalBaptis, @GerejaSidi, @TanggalSidi, @GerejaPernikahan, @TanggalPernikahan, @PendidikanTerakhir, @Pekerjaan, @NamaInstansi, @GolonganDarah, @Pelkat, @Keterangan)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Sektor", comboSektor.Text);
				cmd.Parameters.AddWithValue("@NoKwj", textKwj.Text);
				cmd.Parameters.AddWithValue("@NamaLengkap", textNama.Text);
				cmd.Parameters.AddWithValue("@JenisKelamin", comboJk.Text);
				cmd.Parameters.AddWithValue("@HubunganKeluarga", textHk.Text);
				cmd.Parameters.AddWithValue("@Status", textStatus.Text);
				cmd.Parameters.AddWithValue("@TempatLahir", textTl.Text);
				cmd.Parameters.AddWithValue("@TanggalLahir", maskedLahir.Text);
				cmd.Parameters.AddWithValue("@GerejaBaptis", textBaptis.Text);
				cmd.Parameters.AddWithValue("@TanggalBaptis", maskedBaptis.Text);
				cmd.Parameters.AddWithValue("@GerejaSidi", textSidi.Text);
				cmd.Parameters.AddWithValue("@TanggalSidi", maskedSidi.Text);
				cmd.Parameters.AddWithValue("@GerejaPernikahan", textNikah.Text);
				cmd.Parameters.AddWithValue("@TanggalPernikahan", maskedNikah.Text);
				cmd.Parameters.AddWithValue("@PendidikanTerakhir", comboPendidikan.Text);
				cmd.Parameters.AddWithValue("@Pekerjaan", textKerja.Text);
				cmd.Parameters.AddWithValue("@NamaInstansi", textIns.Text);
				cmd.Parameters.AddWithValue("@GolonganDarah", comboGol.Text);
				cmd.Parameters.AddWithValue("@Pelkat", comboStatus.Text);
				cmd.Parameters.AddWithValue("@Keterangan", textKet.Text);
				
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				
				MessageBox.Show("Jemaat baru telah di tambahkan ke database", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				GetTbgpib();
				reset();
			}
		}
		
		//Get dataGridView
		void JemaatdataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = Convert.ToInt32 (JemaatdataGridView.SelectedRows[0].Cells[0].Value);
			comboSektor.Text = JemaatdataGridView.SelectedRows[0].Cells[1].Value.ToString();
			textKwj.Text = JemaatdataGridView.SelectedRows[0].Cells[2].Value.ToString();
			textNama.Text = JemaatdataGridView.SelectedRows[0].Cells[3].Value.ToString();
			comboJk.Text = JemaatdataGridView.SelectedRows[0].Cells[4].Value.ToString();
			textHk.Text = JemaatdataGridView.SelectedRows[0].Cells[5].Value.ToString();
			textStatus.Text = JemaatdataGridView.SelectedRows[0].Cells[6].Value.ToString();
			textTl.Text = JemaatdataGridView.SelectedRows[0].Cells[7].Value.ToString();
			maskedLahir.Text = JemaatdataGridView.SelectedRows[0].Cells[8].Value.ToString();
			textBaptis.Text = JemaatdataGridView.SelectedRows[0].Cells[9].Value.ToString();
			maskedBaptis.Text = JemaatdataGridView.SelectedRows[0].Cells[10].Value.ToString();
			textSidi.Text = JemaatdataGridView.SelectedRows[0].Cells[11].Value.ToString();
			maskedSidi.Text = JemaatdataGridView.SelectedRows[0].Cells[12].Value.ToString();
			textNikah.Text = JemaatdataGridView.SelectedRows[0].Cells[13].Value.ToString();
			maskedNikah.Text = JemaatdataGridView.SelectedRows[0].Cells[14].Value.ToString();
			comboPendidikan.Text = JemaatdataGridView.SelectedRows[0].Cells[15].Value.ToString();
			textKerja.Text = JemaatdataGridView.SelectedRows[0].Cells[16].Value.ToString();
			textIns.Text = JemaatdataGridView.SelectedRows[0].Cells[17].Value.ToString();
			comboGol.Text = JemaatdataGridView.SelectedRows[0].Cells[18].Value.ToString();
			comboStatus.Text = JemaatdataGridView.SelectedRows[0].Cells[19].Value.ToString();
			textKet.Text = JemaatdataGridView.SelectedRows[0].Cells[20].Value.ToString();
		}
		
		//Reset Button
		void BtnresetClick(object sender, EventArgs e)
		{
			reset();
		}
		
		void BtneditClick(object sender, EventArgs e)
		{
			if (id > 0)
			{
				MySqlCommand cmd = new MySqlCommand ("UPDATE tbgpib SET Sektor = @Sektor, NoKwj = @NoKwj, NamaLengkap = @NamaLengkap, JenisKelamin = @JenisKelamin, HubunganKeluarga = @HubunganKeluarga, Status = @Status, TempatLahir = @TempatLahir, TanggalLahir = @TanggalLahir, GerejaBaptis = @GerejaBaptis, TanggalBaptis = @TanggalBaptis, GerejaSidi = @GerejaSidi, TanggalSidi = @TanggalSidi, GerejaPernikahan = @GerejaPernikahan, TanggalPernikahan = @TanggalPernikahan, PendidikanTerakhir = @PendidikanTerakhir, Pekerjaan = @Pekerjaan, NamaInstansi = @NamaInstansi, GolonganDarah = @GolonganDarah, Pelkat = @Pelkat, Keterangan = @Keterangan WHERE ID = @id", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Sektor", comboSektor.Text);
				cmd.Parameters.AddWithValue("@NoKwj", textKwj.Text);
				cmd.Parameters.AddWithValue("@NamaLengkap", textNama.Text);
				cmd.Parameters.AddWithValue("@JenisKelamin", comboJk.Text);
				cmd.Parameters.AddWithValue("@HubunganKeluarga", textHk.Text);
				cmd.Parameters.AddWithValue("@Status", textStatus.Text);
				cmd.Parameters.AddWithValue("@TempatLahir", textTl.Text);
				cmd.Parameters.AddWithValue("@TanggalLahir", maskedLahir.Text);
				cmd.Parameters.AddWithValue("@GerejaBaptis", textBaptis.Text);
				cmd.Parameters.AddWithValue("@TanggalBaptis", maskedBaptis.Text);
				cmd.Parameters.AddWithValue("@GerejaSidi", textSidi.Text);
				cmd.Parameters.AddWithValue("@TanggalSidi", maskedSidi.Text);
				cmd.Parameters.AddWithValue("@GerejaPernikahan", textNikah.Text);
				cmd.Parameters.AddWithValue("@TanggalPernikahan", maskedNikah.Text);
				cmd.Parameters.AddWithValue("@PendidikanTerakhir", comboPendidikan.Text);
				cmd.Parameters.AddWithValue("@Pekerjaan", textKerja.Text);
				cmd.Parameters.AddWithValue("@NamaInstansi", textIns.Text);
				cmd.Parameters.AddWithValue("@GolonganDarah", comboGol.Text);
				cmd.Parameters.AddWithValue("@Pelkat", comboStatus.Text);
				cmd.Parameters.AddWithValue("@Keterangan", textKet.Text);
				cmd.Parameters.AddWithValue("@id", this.id);
				
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				
				MessageBox.Show("Jemaat di database telah diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);	
					
				GetTbgpib();
				reset();
			}
			else
			{
				MessageBox.Show ("Silahkan Pilih data Jemaat yang akan diubah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnhapusClick(object sender, EventArgs e)
		{
			if (id > 0)
			{
				MySqlCommand cmd = new MySqlCommand ("DELETE FROM tbgpib WHERE id = @id", con);
				cmd.CommandType = CommandType.Text;
						
				cmd.Parameters.AddWithValue("@id", this.id);
						
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
						
				MessageBox.Show ("Jemaat telah dihapus dari database Sektor I", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
				GetTbgpib();
				reset();
			}
			else
			{
				MessageBox.Show ("Silahkan pilih Jemaat yang akan dihapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void cari()
		{
				MySqlDataAdapter DA = new MySqlDataAdapter ("SELECT * FROM tbgpib WHERE NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				JemaatdataGridView.DataSource = DS.Tables[0];
		}
		
		void TextCariTextChanged(object sender, EventArgs e)
		{
			cari();
		}
		
		void Buttonhelp1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Contoh Format = 01 Januari 2001");
		}
		
		void BtncekClick(object sender, EventArgs e)
		{
			if (textKwj.Text == string.Empty || textNama.Text == string.Empty || comboJk.Text == string.Empty || textHk.Text == string.Empty || textStatus.Text == string.Empty || textTl.Text == string.Empty || maskedLahir.Text == string.Empty || textBaptis.Text == string.Empty || maskedBaptis.Text == string.Empty || textSidi.Text == string.Empty || maskedSidi.Text == string.Empty || textNikah.Text == string.Empty || maskedNikah.Text == string.Empty || comboPendidikan.Text == string.Empty || textKerja.Text == string.Empty || textIns.Text == string.Empty || comboGol.Text == string.Empty || comboStatus.Text == string.Empty || textKet.Text == string.Empty)	
			{
				MessageBox.Show("Semua wajib diisi", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (id > 0)
			{
				MessageBox.Show("Klik tombol reset kemudian isi data manual", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else 
			{
				MessageBox.Show("OK", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}