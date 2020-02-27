/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 12:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.OleDb;
namespace Apartment_Rental
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		OleDbConnection connect = new OleDbConnection();
		public Login()
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
		void Button2Click(object sender, EventArgs e)
		{
			Home ins = new Home();
			this.Hide();
			ins.Show();
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			connect.Open();	
			 int count = 0;
			OleDbCommand com = new OleDbCommand();
			com.Connection=connect;
			com.CommandText="select * from Table1 where USERNAME ='" + textBox1.Text + "' AND PASSWORD ='" + textBox2.Text + "'  " ;
			
			OleDbDataReader read = com.ExecuteReader();
				while(read.Read()){		
				count = count +1;
			}
			if(count == 1){
				
			MessageBox.Show("LOGIN SUCCESSFUL");
			Tenants ins = new Tenants();
				
			this.Hide();
			ins.Show();
			}
			else{
				MessageBox.Show("INCORRECT LOGIN DETAILS");
				textBox1.Clear();
				textBox2.Clear();
			}
			connect.Close();
	
		}
	}
}
