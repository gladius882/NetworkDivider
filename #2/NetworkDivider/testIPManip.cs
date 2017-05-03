/*
 * Created by SharpDevelop.
 * User: Patryk
 * Date: 2017-05-03
 * Time: 18:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace NetworkDivider
{
	[TestFixture]
	public class IPManipTest
	{
		[TestCase(11, 3)]
		[TestCase(1001, 9)]
		[TestCase(0101, 5)]
		public void testBinToDec(int given, int expected)
		{
			Assert.AreEqual(expected, IPManip.BinToDec(given));
		}
		
		[TestCase(100000000)]
		[TestCase(-10)]
		[TestCase(2)]
		[TestCase(0x100)]
		public void testBinToDecException(int given)
		{
			Assert.That(()=>IPManip.BinToDec(given), Throws.TypeOf<ArgumentException>());
		}
		
		
		[TestCase(3, 11)]
		[TestCase(9, 1001)]
		[TestCase(23, 10111)]
		public void testDecToBin(int given, int expected)
		{
			Assert.AreEqual(expected, IPManip.DecToBin(given));
		}
		
		[TestCase(256)]
		[TestCase(-1)]
		[TestCase(-256)]
		public void testDecToBinException(int given)
		{
			Assert.That(()=>IPManip.DecToBin(given), Throws.TypeOf<ArgumentException>());
		}
	}
}
