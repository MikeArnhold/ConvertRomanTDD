using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsTDD20210815
{
	[TestClass]
	public class ConvertTests
	{
		[TestMethod]
		public void Test1()
		{
			Assert.AreEqual("I", this.Convert(1));
		}

		[TestMethod]
		public void Test2()
		{
			Assert.AreEqual("II", this.Convert(2));
		}

		[TestMethod]
		public void Test5()
		{
			Assert.AreEqual("V", this.Convert(5));
		}

		[TestMethod]
		public void Test4()
		{
			Assert.AreEqual("IV", this.Convert(4));
		}

		[TestMethod]
		public void Test10()
		{
			Assert.AreEqual("X", this.Convert(10));
		}

		[TestMethod]
		public void Test9()
		{
			Assert.AreEqual("IX", this.Convert(9));
		}

		[TestMethod]
		public void Test11()
		{
			Assert.AreEqual("XI", this.Convert(11));
		}

		[TestMethod]
		public void Test24()
		{
			Assert.AreEqual("XXIV", this.Convert(24));
		}

		[TestMethod]
		public void Test61()
		{
			Assert.AreEqual("LXI", this.Convert(61));
		}

		[TestMethod]
		public void Test561()
		{
			Assert.AreEqual("DLXI", this.Convert(561));
		}

		[TestMethod]
		public void Test2999()
		{
			Assert.AreEqual("MMCMXCIX", this.Convert(2999));
		}

		private string Convert(int number) => RomanNumeralConverter.Convert(number);
	}
}
