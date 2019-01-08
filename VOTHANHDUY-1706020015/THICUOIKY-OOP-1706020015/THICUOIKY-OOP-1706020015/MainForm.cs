/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace THICUOIKY_OOP_1706020015
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsDiem D1 = new clsDiem();
		clsDiem D2 = new clsDiem();
		bool isDrawing = false;
		List<clsPoint> lsPoint = new List<clsPoint>();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
	
		
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				isDrawing = true;
				D1.X = e.X;
				D1.Y = e.Y;
			}
			
		}
		
		void MainFormMouseMove(object sender, MouseEventArgs e)
		{
			if(isDrawing == true)
			{
				if(tsbLine.Checked == true)
			{
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.White),D1.X,D1.Y,D2.X,D2.Y);
					D2.X = e.X;
					D2.Y = e.Y;
					foreach (var element in lsPoint) {
					element.Draw(g,new Pen(Color.Black));
					}
					g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				}
			}
		}
		
		void MainFormMouseUp(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				D2.X = e.X;
				D2.Y = e.Y;
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				isDrawing = false;
				clsLine l = new clsLine(D1,D2);
				lsPoint.Add(l);
				foreach (var element in lsPoint) {
						element.Draw(g,new Pen(Color.Black));
					}
			}
		}
	}
}
