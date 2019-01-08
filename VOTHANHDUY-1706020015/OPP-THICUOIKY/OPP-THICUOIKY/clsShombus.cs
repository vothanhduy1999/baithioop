/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 10:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OPP_THICUOIKY
{
	/// <summary>
	/// Description of clsShombus.
	/// </summary>
	public class clsShombus:clsHinh
	{
		public clsShombus()
		{
		}
		public clsShombus(clsDiem c1, clsDiem c2)
		{
			C1 = c1;
			C2 = c2;
		}
		public override void Draw(System.Drawing.Graphics gr, System.Drawing.Pen pr)
		{
			gr.DrawRectangle(pr,C1.X,C1.Y,C2.X,C2.Y);
		}
	}
}