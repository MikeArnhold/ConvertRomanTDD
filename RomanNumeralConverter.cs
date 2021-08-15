using System;

namespace RomanNumeralsTDD20210815
{
	static class RomanNumeralConverter
	{
		private static string[][] charsets = {
			new string[] { "C", "D", "M" },
			new string[] { "X", "L", "C" },
			new string[] { "I", "V", "X" },
		};
		private static int[][] limits = {
			new int[] {100, 500},
			new int[] {10, 50},
			new int[] {1, 5},
		};

		private static string Convert(string[] chars, int[] limits, ref int number) {
			string roman = "";
			int before = number;
			while (number > 0) {
				if (number - limits[1] >= 0) {
					roman += chars[1];
					number -= limits[1];
				} else if (number - limits[0] >= 0) {
					roman += chars[0];
					number -= limits[0];
				} else {
					break;
				}
				// IIII _> IV
				if (roman.Substring(Math.Max(0, roman.Length - 4)) == $"{chars[0]+chars[0]+chars[0]+chars[0]}") {
					roman = roman.Remove(roman.Length - 4) + $"{chars[0]+chars[1]}";
				}
				// VV -> X
				if (roman.Substring(Math.Max(0, roman.Length - 2)) == $"{chars[1]+chars[1]}") {
					roman = roman.Remove(roman.Length - 2) + $"{chars[2]}";
				}
				// VIV -> IX
				if (roman.Substring(Math.Max(0, roman.Length - 3)) == $"{chars[1]+chars[0]+chars[1]}") {
					roman = roman.Remove(roman.Length - 3) + $"{chars[0]+chars[2]}";
				}
			}
			return roman;
		}

		public static string Convert(int number) {
			string roman = "";
			for(int i = 0; i < RomanNumeralConverter.charsets.Length; ++i) {
				roman += RomanNumeralConverter.Convert(
					RomanNumeralConverter.charsets[i],
					RomanNumeralConverter.limits[i],
					ref number
				);
			}
			return roman;
		}
	}
}
