/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/22/2019
 * Time: 5:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel; 

namespace GPIB
{
	/// <summary>
	/// Description of DataLahir.
	/// </summary>
	public partial class DataLahir : Form
	{
		//ConnectDB
		public DataLahir()
		{
			InitializeComponent();
			this.Text = "Data Ulang Tahun Kelahiran";
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
			
			LahirdataGridView.DataSource = dt;
		}
		
		void DataLahirLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			LahirdataGridView.AllowUserToAddRows = false;
    		LahirdataGridView.AllowUserToDeleteRows = false;
    		LahirdataGridView.AllowUserToOrderColumns = true;
    		LahirdataGridView.ReadOnly = true;
    		LahirdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    		
    		LahirdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		LahirdataGridView.AllowUserToResizeColumns = false;
    		LahirdataGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		LahirdataGridView.AllowUserToResizeRows = false;
    		LahirdataGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    		
    		comboBox1.SelectedItem = "Januari";
    		comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;			
		}
		
		void ComboBox1TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Januari")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/01/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Februari")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/02/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Maret")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/03/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "April")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/04/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Mei")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/05/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Juni")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/06/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Juli")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/07/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Agustus")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/08/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "September")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/09/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Oktober")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/10/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "November")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/11/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Desember")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalLahir LIKE '%/12/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				LahirdataGridView.DataSource = DS.Tables[0];
			}
		}
		
		private void copyAlltoClipboard()
    	{
        	LahirdataGridView.SelectAll();
        	DataObject dataObj = LahirdataGridView.GetClipboardContent();
        	if (dataObj != null)
            Clipboard.SetDataObject(dataObj);
    	}
		
		void Button1Click(object sender, EventArgs e)
		{
			copyAlltoClipboard();
       		Microsoft.Office.Interop.Excel.Application xlexcel;
        	Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        	Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        	object misValue = System.Reflection.Missing.Value;
        	xlexcel = new Excel.Application();
        	xlexcel.Visible = true;
        	xlWorkBook = xlexcel.Workbooks.Add(misValue);
        	xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        	Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
        	CR.Select();
        	xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
		}
	}
}
