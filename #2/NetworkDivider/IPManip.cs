/*
 * Created by SharpDevelop.
 * User: Patryk
 * Date: 2017-05-03
 * Time: 18:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NetworkDivider
{
	public static class IPManip
	{
		public static int BinToDec(int number)
		{
			return Convert.ToInt32(number.ToString(), 2);
		}
		
		public static int DecToBin(int number)
		{
			return -1;
		}
	}
}
