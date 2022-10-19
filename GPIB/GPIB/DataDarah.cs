/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/20/2019
 * Time: 2:44 AM
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
	/// Description of DataDarah.
	/// </summary>
	public partial class DataDarah : Form
	{
		//ConnectDB
		public DataDarah()
		{
			InitializeComponent();
			this.Text = "Data Golongan Darah";
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
			
			DarahGridView.DataSource = dt;
		}
		
		void ComboBox1TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "SEMUA GOL DARAH")
			{
				textCari.Clear();
				GetTbgpib();
			}
			else if (comboBox1.Text == "A")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'A'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "B")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'B'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "O")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'O'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "AB")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'AB'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
		}
		
		void DataDarahLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			DarahGridView.AllowUserToAddRows = false;
    		DarahGridView.AllowUserToDeleteRows = false;
    		DarahGridView.AllowUserToOrderColumns = true;
    		DarahGridView.ReadOnly = true;
    		DarahGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    		
    		DarahGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		DarahGridView.AllowUserToResizeColumns = false;
    		DarahGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		DarahGridView.AllowUserToResizeRows = false;
    		DarahGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    		
			comboBox1.SelectedItem = "SEMUA GOL DARAH";
    		comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		
		void TextCariTextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "SEMUA GOL DARAH")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "A")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'A' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "B")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'B' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "O")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'O' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
			else if (comboBox1.Text == "AB")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE GolonganDarah LIKE 'AB' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				DarahGridView.DataSource = DS.Tables[0];
			}
		}
		
		private void copyAlltoClipboard()
    	{
        	DarahGridView.SelectAll();
        	DataObject dataObj = DarahGridView.GetClipboardContent();
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
