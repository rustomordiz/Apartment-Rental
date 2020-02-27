/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 26/02/2020
 * Time: 6:22 PM
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
	/// Description of Tenants.
	/// </summary>
	public partial class Tenants : Form
	{
		OleDbConnection connect = new OleDbConnection();
		public Tenants()
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
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void LogoutClick(object sender, EventArgs e)
		{
			Home ins = new Home();
			this.Hide();
			ins.Show();
	
		}
		
		void TenantsLoad(object sender, EventArgs e)
		{
			string dateValue;
			
			disable();
			connect.Open();
		
			//NAKATIRA SA A1 ROOM
					
				OleDbCommand com1 = new OleDbCommand();
				com1.Connection=connect;
				com1.CommandText="select * from Table2 where ROOM= '1A' ";
				OleDbDataReader read1 = com1.ExecuteReader();
				while(read1.Read()){
				name1.Text=Convert.ToString(read1["USERNAME"]);
				contact1.Text=Convert.ToString(read1["CONTACT"]);
				room1.Text=Convert.ToString(read1["ROOM"]);
				dateValue= Convert.ToString(read1["RENTDATE"]);
				date1.Value = DateTime.Parse(dateValue);
				}
				
			//NAKATIRA SA A2 ROOM
					
				OleDbCommand com2 = new OleDbCommand();
				com2.Connection=connect;
				com2.CommandText="select * from Table2 where ROOM= '2A' ";
				OleDbDataReader read2 = com2.ExecuteReader();
				while(read2.Read()){
				name2.Text=Convert.ToString(read2["USERNAME"]);
				contact2.Text=Convert.ToString(read2["CONTACT"]);
				room2.Text=Convert.ToString(read2["ROOM"]);
				dateValue= Convert.ToString(read2["RENTDATE"]);
				date2.Value = DateTime.Parse(dateValue);
				}
				
			//NAKATIRA SA A3 ROOM
					
				OleDbCommand com3 = new OleDbCommand();
				com3.Connection=connect;
				com3.CommandText="select * from Table2 where ROOM= '3A' ";
				OleDbDataReader read3 = com3.ExecuteReader();
				while(read3.Read()){
				name3.Text=Convert.ToString(read3["USERNAME"]);
				contact3.Text=Convert.ToString(read3["CONTACT"]);
				room3.Text=Convert.ToString(read3["ROOM"]);
				dateValue= Convert.ToString(read3["RENTDATE"]);
				date3.Value = DateTime.Parse(dateValue);
				}
				
			//NAKATIRA SA 1B ROOM
					
				OleDbCommand com4 = new OleDbCommand();
				com4.Connection=connect;
				com4.CommandText="select * from Table2 where ROOM= '1B' ";
				OleDbDataReader read4 = com4.ExecuteReader();
				while(read4.Read()){
				name4.Text=Convert.ToString(read4["USERNAME"]);
				contact4.Text=Convert.ToString(read4["CONTACT"]);
				room4.Text=Convert.ToString(read4["ROOM"]);
				dateValue= Convert.ToString(read4["RENTDATE"]);
				date4.Value = DateTime.Parse(dateValue);
				}
			
			//NAKATIRA SA 2B ROOM
					
				OleDbCommand com5 = new OleDbCommand();
				com5.Connection=connect;
				com5.CommandText="select * from Table2 where ROOM= '2B' ";
				OleDbDataReader read5 = com5.ExecuteReader();
				while(read5.Read()){
				name5.Text=Convert.ToString(read5["USERNAME"]);
				contact5.Text=Convert.ToString(read5["CONTACT"]);
				room5.Text=Convert.ToString(read5["ROOM"]);
				dateValue= Convert.ToString(read5["RENTDATE"]);
				date5.Value = DateTime.Parse(dateValue);
				}
			
			//NAKATIRA SA 1C ROOM
					
				OleDbCommand com6 = new OleDbCommand();
				com6.Connection=connect;
				com6.CommandText="select * from Table2 where ROOM= '1C' ";
				OleDbDataReader read6 = com6.ExecuteReader();
				while(read6.Read()){
				name6.Text=Convert.ToString(read6["USERNAME"]);
				contact6.Text=Convert.ToString(read6["CONTACT"]);
				room6.Text=Convert.ToString(read6["ROOM"]);
				dateValue= Convert.ToString(read6["RENTDATE"]);
				date6.Value = DateTime.Parse(dateValue);
				}
				
			//NAKATIRA SA 2C ROOM
					
				OleDbCommand com7 = new OleDbCommand();
				com7.Connection=connect;
				com7.CommandText="select * from Table2 where ROOM= '2C' ";
				OleDbDataReader read7 = com7.ExecuteReader();
				while(read7.Read()){
				name7.Text=Convert.ToString(read7["USERNAME"]);
				contact7.Text=Convert.ToString(read7["CONTACT"]);
				room7.Text=Convert.ToString(read7["ROOM"]);
				dateValue= Convert.ToString(read7["RENTDATE"]);
				date7.Value = DateTime.Parse(dateValue);
				}
			
				connect.Close();
			
		}
		void disable(){
			name1.Enabled=false;
			name2.Enabled=false;
			name3.Enabled=false;
			name4.Enabled=false;
			name5.Enabled=false;
			name6.Enabled=false;
			name7.Enabled=false;
			
			room1.Enabled=false;
			room2.Enabled=false;
			room3.Enabled=false;
			room4.Enabled=false;
			room5.Enabled=false;
			room6.Enabled=false;
			room7.Enabled=false;
			
			contact1.Enabled=false;
			contact2.Enabled=false;
			contact3.Enabled=false;
			contact4.Enabled=false;
			contact5.Enabled=false;
			contact6.Enabled=false;
			contact7.Enabled=false;
			
			date1.Enabled=false;
			date2.Enabled=false;
			date3.Enabled=false;
			date4.Enabled=false;
			date5.Enabled=false;
			date6.Enabled=false;
			date7.Enabled=false;
		}
	}
}
