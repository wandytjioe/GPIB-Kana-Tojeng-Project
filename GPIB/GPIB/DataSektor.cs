/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/12/2019
 * Time: 2:38 AM
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
	/// Description of DataSektor.
	/// </summary>
	public partial class DataSektor : Form
	{
		//ConnectDB
		public DataSektor()
		{
			InitializeComponent();
			this.Text = "Data Sektor";
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
			
			SektordataGridView.DataSource = dt;
		}
		
		void DataSektorLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			SektordataGridView.AllowUserToAddRows = false;
    		SektordataGridView.AllowUserToDeleteRows = false;
    		SektordataGridView.AllowUserToOrderColumns = true;
    		SektordataGridView.ReadOnly = true;
    		SektordataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

    		SektordataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		SektordataGridView.AllowUserToResizeColumns = false;
    		SektordataGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		SektordataGridView.AllowUserToResizeRows = false;
    		SektordataGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    		
    		comboBox1.SelectedItem = "Semua Sektor";
    		comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		
		void ComboBox1TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Semua Sektor")
			{
				textCari.Clear();
				GetTbgpib();
			}
			
			else if (comboBox1.Text == "Sektor I")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Sektor LIKE 'Sektor I'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "Sektor II")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Sektor LIKE 'Sektor II'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "Sektor III")
			{
				textCari.Clear();
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Sektor LIKE 'Sektor III'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Semua Sektor")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "Sektor I")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Sektor LIKE 'Sektor I' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "Sektor II")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Sektor LIKE 'Sektor II' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}
			
			else if (comboBox1.Text == "Sektor III")
			{
				MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from tbgpib WHERE Sektor LIKE 'Sektor III' && NamaLengkap LIKE '%"+textCari.Text+"%'", con);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				SektordataGridView.DataSource = DS.Tables[0];
			}			
		}
		
		private void copyAlltoClipboard()
    	{
        	SektordataGridView.SelectAll();
        	DataObject dataObj = SektordataGridView.GetClipboardContent();
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
