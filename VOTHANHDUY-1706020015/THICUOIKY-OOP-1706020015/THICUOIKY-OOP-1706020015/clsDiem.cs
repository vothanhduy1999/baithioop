/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace THICUOIKY_OOP_1706020015
{
	/// <summary>
	/// Description of clsDiem.
	/// </summary>
	public class clsDiem
	{
		int ix,iy;
		public int X
		{
			get
			{
				return ix;
			}
			set
			{
				ix = value;
			}
			
		}
		public int Y
		{
			get
			{
				return iy;
			}
			set
			{
				iy = value;
			}
		}
		public clsDiem()
		{
			X = 0;
			Y = 0;
		}
		public clsDiem(int a, int b)
		{
			X = a;
			Y = b;
		}
	}
}
