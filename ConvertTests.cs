using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsTDD20210815
{
	[TestClass]
	public class ConvertTests
	{

		private string Convert(int number) => RomanNumeralConverter.Convert(number);
	}
}
