/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 8/30/2019
 * Time: 11:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace GPIB
{
	/// <summary>
	/// Description of connectionService.
	/// </summary>
	public class connectionService
	{
		public static MySqlConnection getConnection()
		{
			MySqlConnection con = null;
			try
			{
				string sConString = "server=localhost;database=dbgpib;uid=root;password=htdnqenf;Allow User Variables=True";
				con = new MySqlConnection (sConString);
			}
			catch (MySqlException sqlex)
			{
				throw new Exception (sqlex.Message.ToString());
			}
			return con;
		}
	}
}
