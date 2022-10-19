/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/24/2019
 * Time: 1:12 AM
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
	/// Description of DataNikah.
	/// </summary>
	public partial class DataNikah : Form
	{
		//ConnectDB
		public DataNikah()
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
			
			NikahdataGridView.DataSource = dt;
		}
		
		void DataNikahLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			NikahdataGridView.AllowUserToAddRows = false;
    		NikahdataGridView.AllowUserToDeleteRows = false;
    		NikahdataGridView.AllowUserToOrderColumns = true;
    		NikahdataGridView.ReadOnly = true;
    		NikahdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    		
    		NikahdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		NikahdataGridView.AllowUserToResizeColumns = false;
    		NikahdataGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		NikahdataGridView.AllowUserToResizeRows = false;
    		NikahdataGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    		
    		comboBox1.SelectedItem = "Januari";
    		comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;			
		}
		
		void ComboBox1TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Januari")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/01/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Februari")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/02/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Maret")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/03/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "April")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/04/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Mei")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/05/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Juni")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/06/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Juli")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/07/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Agustus")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/08/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "September")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/09/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Oktober")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/10/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "November")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/11/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "Desember")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE TanggalPernikahan LIKE '%/12/%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				NikahdataGridView.DataSource = DS.Tables[0];
			}
		}
		
		private void copyAlltoClipboard()
    	{
        	NikahdataGridView.SelectAll();
        	DataObject dataObj = NikahdataGridView.GetClipboardContent();
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
