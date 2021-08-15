using System;
using System.Linq;

namespace RomanNumeralsTDD20210815
{
	static class Converter
	{
		private static (string chars, int low, int high)[] bounds
			= new (string, int, int)[] {
				("CDM", 100, 500),
				("XLC", 10, 50),
				("IVX", 1, 5),
			};

		private static bool MatchEnd(string orig, string match) {
			int from = Math.Max(0, orig.Length - match.Length);
			return orig.Substring(from) == match;
		}

		private static string Replace(string orig, int removeChars, string add) {
			int from = orig.Length - removeChars;
			return $"{orig.Remove(from)}{add}";
		}

		private static Func<string, string> FixIIII(string chars) => orig => {
			char I = chars[0];
			char V = chars[1];
			return Converter.MatchEnd(orig, $"{I}{I}{I}{I}")
				? Converter.Replace(orig, 4, $"{I}{V}")
				: orig;
		};

		private static Func<string, string> FixVV(string chars) => str => {
			char V = chars[1];
			char X = chars[2];
			return Converter.MatchEnd(str, $"{V}{V}")
				? Converter.Replace(str, 2, $"{X}")
				: str;
		};

		private static Func<string, string> FixVIV(string chars) => orig => {
			char I = chars[0];
			char V = chars[1];
			char X = chars[2];
			return Converter.MatchEnd(orig, $"{V}{I}{V}")
				? Converter.Replace(orig, 3, $"{I}{X}")
				: orig;
		};

		private static string Fix(string roman, string chars) {
			string apply(string result, Func<string, string> fix) {
				return fix(result);
			}
			Func<string, string>[] fixers = new Func<string, string>[] {
				Converter.FixIIII(chars),
				Converter.FixVV(chars),
				Converter.FixVIV(chars),
			};
			return fixers.Aggregate(roman, apply);
		}

		private static (string, int) Convert((string, int) number, (string, int, int) bounds) {
			(string chars, int low, int high) = bounds;
			(string roman, int value) = number;
			char I = chars[0];
			char V = chars[1];
			if (value - high >= 0) {
				roman = Converter.Fix($"{roman}{V}", chars);
				return Converter.Convert((roman, value - high), bounds);
			}
			if (value - low >= 0) {
				roman = Converter.Fix($"{roman}{I}", chars);
				return Converter.Convert((roman, value - low), bounds);
			}
			return number;
		}

		public static string Convert(int number) {
			(string, int) apply((string, int) number, (string, int, int) bounds) {
				return Converter.Convert(number, bounds);
			}
			(string roman, int value) result = (roman: "", value: number);
			result = Converter.bounds.Aggregate(result, apply);
			return result.roman;
		}
	}
}
