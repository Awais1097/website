﻿/*
 * Created by SharpDevelop.
 * User: NASIR
 * Date: 11/15/2022
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of FormCategory.
	/// </summary>
	public partial class FormCategory : Form
	{
		string fileName;
		public FormCategory()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog(); 
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
			if (open.ShowDialog() == DialogResult.OK) {  
    			// display image in picture box  
    		pictureBox2.Image = new Bitmap(open.FileName);  
    		// image file path  
    		fileName = open.FileName;  
			}			
		}
	}
}
