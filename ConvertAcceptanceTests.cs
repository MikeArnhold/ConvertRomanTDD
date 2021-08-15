using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsTDD20210815
{
	[TestClass]
	public class ConvertAcceptanceTests
	{
		[TestMethod]
		public void romanNumeralForOneIsI() {
			Assert.AreEqual("I", this.Convert(1));
		}

		[TestMethod]
		public void romanNumeralForTwoIsII() {
			Assert.AreEqual("II", this.Convert(2));
		}

		[TestMethod]
		public void romanNumeralForThreeIsIII() {
			Assert.AreEqual("III", this.Convert(3));
		}

		[TestMethod]
		public void romanNumeralForFourIsIV() {
			Assert.AreEqual("IV", this.Convert(4));
		}

		[TestMethod]
		public void romanNumeralForFiveIsV() {
			Assert.AreEqual("V", this.Convert(5));
		}

		[TestMethod]
		public void romanNumeralForSixIsVI() {
			Assert.AreEqual("VI", this.Convert(6));
		}

		[TestMethod]
		public void romanNumeralForNineIsIX() {
			Assert.AreEqual("IX", this.Convert(9));
		}

		[TestMethod]
		public void romanNumeralForTenIsX() {
			Assert.AreEqual("X", this.Convert(10));
		}

		[TestMethod]
		public void romanNumeralForElevenIsXI() {
			Assert.AreEqual("XI", this.Convert(11));
		}

		[TestMethod]
		public void romanNumeralForFourteenIsXIV() {
			Assert.AreEqual("XIV", this.Convert(14));
		}

		[TestMethod]
		public void romanNumeralForFifteenIsXV() {
			Assert.AreEqual("XV", this.Convert(15));
		}

		[TestMethod]
		public void romanNumeralForNineteenIsXIX() {
			Assert.AreEqual("XIX", this.Convert(19));
		}

		[TestMethod]
		public void romanNumeralForTwentyIsXX() {
			Assert.AreEqual("XX", this.Convert(20));
		}

		[TestMethod]
		public void romanNumeralForFortyIsXL() {
			Assert.AreEqual("XL", this.Convert(40));
		}

		[TestMethod]
		public void romanNumeralForFortyNineIsXLIX() {
			Assert.AreEqual("XLIX", this.Convert(49));
		}

		[TestMethod]
		public void romanNumeralForFiftyIsL() {
			Assert.AreEqual("L", this.Convert(50));
		}

		[TestMethod]
		public void romanNumeralForFiftyOneIsLI() {
			Assert.AreEqual("LI", this.Convert(51));
		}

		[TestMethod]
		public void romanNumeralForNinetyIsXC() {
			Assert.AreEqual("XC", this.Convert(90));
		}

		[TestMethod]
		public void romanNumeralForNinetyNineIsXCIX() {
			Assert.AreEqual("XCIX", this.Convert(99));
		}

		[TestMethod]
		public void romanNumeralForOneHundredIsC() {
			Assert.AreEqual("C", this.Convert(100));
		}

		[TestMethod]
		public void romanNumeralForOneHundredAndOneIsCI() {
			Assert.AreEqual("CI", this.Convert(101));
		}

		[TestMethod]
		public void romanNumeralForFourHundredIsCD() {
			Assert.AreEqual("CD", this.Convert(400));
		}

		[TestMethod]
		public void romanNumeralForFourHundredNinetyNineIsCDXCIX() {
			Assert.AreEqual("CDXCIX", this.Convert(499));
		}

		[TestMethod]
		public void romanNumeralForFiveHundredIsD() {
			Assert.AreEqual("D", this.Convert(500));
		}

		[TestMethod]
		public void romanNumeralForFiveHundredAndOneIsDI() {
			Assert.AreEqual("DI", this.Convert(501));
		}

		[TestMethod]
		public void romanNumeralForNineHundredIsCM() {
			Assert.AreEqual("CM", this.Convert(900));
		}

		[TestMethod]
		public void romanNumeralForNineHundredNinetyNineIsCMXCIX() {
			Assert.AreEqual("CMXCIX", this.Convert(999));
		}

		[TestMethod]
		public void romanNumeralForOneThousandIsM() {
			Assert.AreEqual("M", this.Convert(1000));
		}

		[TestMethod]
		public void romanNumeralForOneThousandAndOneIsMI() {
			Assert.AreEqual("MI", this.Convert(1001));
		}

		[TestMethod]
		public void romanNumeralFor4999IsMMMMCMXCIX() {
			Assert.AreEqual("MMMMCMXCIX", this.Convert(4999));
		}

		private string Convert(int number) {
			return Converter.Convert(number);
		}
	}
}
