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
	/// Description of clsTraingle.
	/// </summary>
	public class clsTraingle: clsHinh
	{
		public clsTraingle()
		{
		}
		public clsTraingle(clsDiem r1, clsDiem r2)
		{
			R1 = r1;
			R2 = r2;
		}
		public override void Draw(System.Drawing.Graphics gr, System.Drawing.Pen pr)
		{
			gr.DrawRectangle(pr,R1.X,R1.Y,R2.X,R2.Y);
		}
	}
}
