/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 17/02/2020
 * Time: 12:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Apartment_Rental
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
		
	{	
		OleDbConnection connect = new OleDbConnection();
		public static string room = "";  
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tommy\Documents\SharpDevelop Projects\Apartment Rental\Database.accdb;
Persist Security Info=False;";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			//CHECK ROOM AVAILABLE
			List<string> xy = new List<string>();
			
	
			connect.Open();
			OleDbCommand com = new OleDbCommand();
			com.Connection=connect;
			com.CommandText="select ROOM from Table2 ";
			
			OleDbDataReader read = com.ExecuteReader();
			while(read.Read()){
				xy.Add(Convert.ToString(read["ROOM"]));
				
			}
			foreach(string room in xy){
				if(room=="1A"){
					A1.Enabled=false;
				}
				if(room=="2A"){
					A2.Enabled=false;
				}
				if(room=="3A"){
					A3.Enabled=false;
				}
				if(room=="1B"){
					B1.Enabled=false;
				}
				if(room=="2B"){
					B2.Enabled=false;
				}
				if(room=="1C"){
					C1.Enabled=false;
				}
				if(room=="2C"){
					C2.Enabled=false;
				}
			}
				connect.Close();
				
		}
		void A2Click(object sender, EventArgs e)
		{
			room = "2A";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
	
		}
		void A1Click(object sender, EventArgs e)
		{
			room = "1A";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
		}
		void B1Click(object sender, EventArgs e)
		{
			room = "1B";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
	
		}
		void C1Click(object sender, EventArgs e)
		{
			room = "1C";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
	
		}
		void C2Click(object sender, EventArgs e)
		{
			room = "2C";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
	
		}
		void B2Click(object sender, EventArgs e)
		{	
			room = "2B";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
	
		}
		void A3Click(object sender, EventArgs e)
		{
			room = "3A";
			Form1 ins = new Form1();
			this.Hide();
			ins.Show();
		}
		void BackClick(object sender, EventArgs e)
		{
			Home ins = new Home();
			this.Hide();
			ins.Show();
	
		}
		
	}
}
