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
			try {
				if(number < 0 || number > 11111111)
					throw new Exception();
				return Convert.ToInt32(number.ToString(), 2);
			}
			catch {
				throw new ArgumentException();
			}
		}
		
		public static int DecToBin(int number)
		{
			try {
				if(number < 0 || number > 255)
					throw new Exception();
				return int.Parse(Convert.ToString(number, 2));
			}
			catch {
				throw new ArgumentException();
			}
		}
	}
}
