/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.IO;
using System.Linq;

using  Newtonsoft.Json;

namespace Newtonsoft.Json
{
}
namespace OPP_THICUOIKY
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsDiem D1 = new clsDiem();
		clsDiem D2 = new clsDiem();
		clsDiem R1 = new clsDiem();
		clsDiem R2 = new clsDiem();
		clsDiem C1 = new clsDiem();
		clsDiem C2 = new clsDiem();
		bool isDrawing = false;
		List<clsHinh> lsHinh = new List<clsHinh>();
		
		Image  File;
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
		
		void PbDrawMouseMove(object sender, MouseEventArgs e)
		{
			if(isDrawing == true)
			{
				if(tsbLine.Checked == true)
				{
					System.Drawing.Graphics g = pbDraw.CreateGraphics();
					g.DrawLine(new Pen(Color.White),D1.X,D1.Y,D2.X,D2.Y);
					D2.X = e.X;
					D2.Y = e.Y;
					foreach (var element in lsHinh) {
						element.Draw(g,new Pen(Color.Black));
					}
					g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				}}}
			
			
		
		void PbDrawMouseUp(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				D2.X = e.X;
				D2.Y = e.Y;
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				isDrawing = false;
				
//				clsLine l = new clsLine();
//				l.D1 = D1;
//				l.D2 = D2;
				clsLine l = new clsLine(D1,D2);
				lsHinh.Add(l);
				foreach (var element in lsHinh) {
						element.Draw(g,new Pen(Color.Black));
					}
			}
			
		}
		
		void PbDrawMouseDown(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				isDrawing = true;
				D1.X = e.X;
				D1.Y = e.Y;
			}
				
				
		}
		void SaveClick(object sender, EventArgs e)
		{
			SaveFileDialog Save = new SaveFileDialog();
			Save.Filter = "Json Filter | .json|All Filter|.*";
			if ( Save.ShowDialog() == DialogResult.OK)
			{
				string fileName = Save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(lsHinh);
				StreamWriter writer = new StreamWriter(fileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("success");
			}
		}
		
		void LoadClick(object sender, EventArgs e)
		{
			OpenFileDialog Load = new OpenFileDialog();
			Load.Filter =  "Json Filter | *.json|All Filter|*.*";
			if ( Load.ShowDialog() == DialogResult.OK)
			{
				string sFileName = Load.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var DeserializeObject = serializer.Deserialize<List<clsShombus>>(json);
				foreach ( var element in DeserializeObject)
				{
				}
				MessageBox.Show("Load OK");
		}
	}
	}
}