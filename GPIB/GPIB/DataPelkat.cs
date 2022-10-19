/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/19/2019
 * Time: 12:20 AM
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
	/// Description of DataPelkat.
	/// </summary>
	public partial class DataPelkat : Form
	{
		//ConnectDB
		public DataPelkat()
		{
			InitializeComponent();
			this.Text = "Data Pelkat";
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
			
			PelkatdataGridView.DataSource = dt;
		}
		
		void DataPelkatLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			PelkatdataGridView.AllowUserToAddRows = false;
    		PelkatdataGridView.AllowUserToDeleteRows = false;
    		PelkatdataGridView.AllowUserToOrderColumns = true;
    		PelkatdataGridView.ReadOnly = true;
    		PelkatdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    		
    		PelkatdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		PelkatdataGridView.AllowUserToResizeColumns = false;
    		PelkatdataGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		PelkatdataGridView.AllowUserToResizeRows = false;
    		PelkatdataGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    		
    		comboBox1.SelectedItem = "SEMUA PELKAT";
    		comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		
		void ComboBox1TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "SEMUA PELKAT")
			{
				textCari.Clear();
				GetTbgpib();
			}
			
			else if (comboBox1.Text == "PA")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PA'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "PT")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PT'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "GP")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'GP'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "PKP")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PKP'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "PKB")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PKB'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "PKLU")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PKLU'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
		}
		
		void TextCariTextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "SEMUA PELKAT")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "PA")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PA' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "PT")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PT' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "GP")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'GP' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "PKP")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PKP' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "PKB")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PKB' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "PKLU")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Pelkat LIKE 'PKLU' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				PelkatdataGridView.DataSource = DS.Tables[0];
			}
		}
		
		private void copyAlltoClipboard()
    	{
        	PelkatdataGridView.SelectAll();
        	DataObject dataObj = PelkatdataGridView.GetClipboardContent();
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
