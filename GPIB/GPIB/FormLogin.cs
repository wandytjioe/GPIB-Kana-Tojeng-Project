/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 8/31/2019
 * Time: 12:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace GPIB
{
	/// <summary>
	/// Description of FormLogin.
	/// </summary>
	public partial class FormLogin : Form
	{
		//ConnectDB
		MySqlConnection con = connectionService.getConnection();
		public FormLogin()
		{
			InitializeComponent();
			this.Text = "Login";
		}
		
		
		//LoginProcess
		void prosesLogin()
		{
			if (login(textusername.Text,textpassword.Text))
			{
				labelsalah.Visible = false;
				MainForm.strmn.logoutToolStripMenuItem.Enabled = true;
				MainForm.strmn.menuToolStripMenuItem.Enabled = true;
				MainForm.strmn.dataSektorToolStripMenuItem.Enabled = true;
				MainForm.strmn.loginToolStripMenuItem.Enabled = false;
				this.Close();
			}
			else
			{
				labelsalah.Visible = true;
			}
		}
		
		//LoginButton
		void BtnloginClick(object sender, EventArgs e)
		{
			prosesLogin();
		}
		
		//AdminDB
		private Boolean login(string sUsername,string sPassword)
		{
			string SQL = "SELECT username,password FROM formlogin";
			
			con.Open();
			MySqlCommand cmd = new MySqlCommand (SQL, con);
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				if ((sUsername==reader.GetString(0))&&(sPassword==reader.GetString(1)))
				{
					con.Close();
					return true;
				}
			}
			con.Close();
			return false;
		}
		
		//CancelButton
		void BtnbatalClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//FormLoginLoad
		void FormLoginLoad(object sender, EventArgs e)
		{
			textusername.Focus(); //UsernameFocus
		}
		
		//KeyPress Enter
		void TextusernameKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				prosesLogin();
			}
		}
		
		//KeyPress Enter
		void TextpasswordKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				prosesLogin();
			}
		}
	}
}
