/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 1:03 AM
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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		OleDbConnection connect = new OleDbConnection();
		public Form1()
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
		//NAME
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			 textBox1.CharacterCasing = CharacterCasing.Normal;
            if((System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^A-Z]"))){
                MessageBox.Show("Capital Letters Only");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
	
		}
		//CONTACT
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			textBox2.MaxLength = 3;
            textBox2.CharacterCasing = CharacterCasing.Normal;
            if(System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]")){
                MessageBox.Show("Numbers Only");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			MainForm ins = new MainForm();
			this.Hide();
			ins.Show();
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
	
		}
		void Form1Load(object sender, EventArgs e)
		{
		textBox3.Text=MainForm.room;
		timer1.Start();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text=="" && textBox2.Text==""){
				MessageBox.Show("Fill up all the details!");
			}
			else{
			
			
			try{
			connect.Open();
			OleDbCommand com = new OleDbCommand();
			com.Connection=connect;
			com.CommandText = "insert into Table2(USERNAME,CONTACT,RENTDATE,ROOM) values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox3.Text + "') ";
		    com.ExecuteNonQuery();
			MessageBox.Show("RESERVATION SUCCESS!");
			//Clear then go home
			clear();
			Home ins = new Home();
			this.Hide();
			ins.Show();
			
			}catch(System.Data.OleDb.OleDbException){
				MessageBox.Show("RESERVATION FAILED!");
			}
			
			connect.Close();
			
			}
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Timer1Tick(object sender, EventArgs e)
		{
		
		}
		void clear(){
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
		}
		
	}
}
