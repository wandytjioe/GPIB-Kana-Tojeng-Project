/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/20/2019
 * Time: 2:33 AM
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
	/// Description of DataKelurga.
	/// </summary>
	public partial class DataKelurga : Form
	{
		//ConnectDB
		public DataKelurga()
		{
			InitializeComponent();
			this.Text = "Data Keluarga";
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
			
			KeluargadataGridView.DataSource = dt;
		}
		
		void DataKelurgaLoad(object sender, EventArgs e)
		{
			GetTbgpib();
			KeluargadataGridView.AllowUserToAddRows = false;
    		KeluargadataGridView.AllowUserToDeleteRows = false;
    		KeluargadataGridView.AllowUserToOrderColumns = true;
    		KeluargadataGridView.ReadOnly = true;
    		KeluargadataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    		
    		KeluargadataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    		KeluargadataGridView.AllowUserToResizeColumns = false;
    		KeluargadataGridView.ColumnHeadersHeightSizeMode = 
        	DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    		KeluargadataGridView.AllowUserToResizeRows = false;
    		KeluargadataGridView.RowHeadersWidthSizeMode = 
        	DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    		
    		
		}
		
		void TextCariTextChanged(object sender, EventArgs e)
		{
			MySqlDataAdapter DA = new MySqlDataAdapter ("SELECT * FROM tbgpib WHERE NoKwj LIKE '%"+textCari.Text+"%'", con);
			DataSet DS = new DataSet();
			DA.Fill(DS);
			KeluargadataGridView.DataSource = DS.Tables[0];
		}
		
		private void copyAlltoClipboard()
    	{
        	KeluargadataGridView.SelectAll();
        	DataObject dataObj = KeluargadataGridView.GetClipboardContent();
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
