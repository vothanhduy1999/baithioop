/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 9:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace THICUOIKY_OOP_1706020015
{
	/// <summary>
	/// Description of clsLine.
	/// </summary>
	public class clsLine : clsPoint
	{
		public clsLine()
		{
		}
		public clsLine(clsDiem d1, clsDiem d2)
		{
			D1 = d1;
			D2 = d2;
		}
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen p)
		{
			g.DrawLine(p,D1.X,D1.Y,D2.X,D2.Y);
		}
	}
}
