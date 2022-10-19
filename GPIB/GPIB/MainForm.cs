/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 8/30/2019
 * Time: 10:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GPIB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static MainForm strmn;
		public MainForm()
		{
			InitializeComponent();	
		}
			
		void MainFormLoad(object sender, EventArgs e)
		{
			logoutToolStripMenuItem.Enabled = false;
			menuToolStripMenuItem.Enabled = false;
			dataSektorToolStripMenuItem.Enabled = false;
			loginToolStripMenuItem.Enabled = true;
			strmn = this;
		}
		
		void LoginToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormLogin oFormLogin = new FormLogin();
			oFormLogin.ShowDialog();
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult dialogresult = MessageBox.Show ("Yakin ingin keluar?", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogresult == DialogResult.Yes)
			{
				Application.Exit();
			}
			else if(dialogresult == DialogResult.No)
			{
				
			}

		}
		
		void LogoutToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult dialogresult = MessageBox.Show ("Yakin ingin logout?", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogresult == DialogResult.Yes)
			{
				logoutToolStripMenuItem.Enabled = false;
				menuToolStripMenuItem.Enabled = false;
				dataSektorToolStripMenuItem.Enabled = false;
				loginToolStripMenuItem.Enabled = true;
				MessageBox.Show ("Berhasil logout", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(dialogresult == DialogResult.No)
			{
				
			}
						
		}
		
		void InputEditHapusToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormCRUD oFormCRUD = new FormCRUD();
			oFormCRUD.ShowDialog();
		}
		
		void SektorIToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataSektor oDataSektor = new DataSektor();
			oDataSektor.ShowDialog();
		}
		
		void PelkatToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataPelkat oDataPelkat = new DataPelkat();
			oDataPelkat.ShowDialog();
		}
		
		void DataKeluargaToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataKelurga oDataKeluarga = new DataKelurga();
			oDataKeluarga.ShowDialog();
		}
		
		void DataGolDarahToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataDarah oDataDarah = new DataDarah();
			oDataDarah.ShowDialog();
		}
		
		void DataUltahKelahiranToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataLahir oDataLahir = new DataLahir();
			oDataLahir.ShowDialog();
		}
		
		void DataUltahPernikahanToolStripMenuItemClick(object sender, EventArgs e)
		{
			DataNikah oDataNikah = new DataNikah();
			oDataNikah.ShowDialog();
		}
	}
}
