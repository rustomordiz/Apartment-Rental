/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 21/02/2020
 * Time: 12:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Apartment_Rental
{
	/// <summary>
	/// Description of Home.
	/// </summary>
	public partial class Home : Form
	{
		public Home()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			Login ins = new Login();
			this.Hide();
			ins.Show();
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			MainForm ins = new MainForm();
			this.Hide();
			ins.Show();
	
		}
	}
}
