using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace COPStarter
{
	public class COPMethods
	{
		public bool SliceOfPie(int totalSlices, int numberOfRecipients, int slicesEach)
		{
			try
			{
				if ((numberOfRecipients * slicesEach) <= totalSlices)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public string ShuffleTheName(string firstNameAndLastName)
		{
			string[] result = firstNameAndLastName.Split(' ');

			return result[1] + " " + result[0];
		}

		public int CountSyllables(string word)
		{
			return word.Split('-').Length;
		}

		public bool XsAndOs(string xAndO)
		{
			var a = xAndO.Count(c => c == 'x' || c == 'X');

			var b = xAndO.Count(c => c == 'o' || c == 'O');

			if (a == b)
			{
				return true;
			}
			return false;
		}

		public bool StrangePair(string one, string two)
		{
			if (string.IsNullOrEmpty(one) || string.IsNullOrEmpty(two))
			{
				return one == two;
			}

			return one.First() == two.Last() && two.First() == one.Last();
		}

		public bool PrimeNumber(int number)
		{
			int i = 2;
			while (i++ <= number && number % i != 0) ;
			return i == number;
		}

		public int[] RemoveLowest(int[] array)
		{
			List<int> list = array.ToList();
			if (list.Count != 0)
			{
				list.Remove(list.Min());
			}

			return list.ToArray();
		}

		public string ConvertZeroAndOne(string words)
		{
			words = words.ToLower();
			words = Regex.Replace(words, "one", "1");
			words = Regex.Replace(words, "zero", "0");
			words = Regex.Replace(words, " ", "");
			words = Regex.Replace(words, "\\D", "");

            if (words.Length % 8 != 0)
            {
				words = words.Remove(words.Length - (words.Length % 8));
            }

            return words;
		}

		public int SockPairs(string socks)
		{
			return socks.ToCharArray().GroupBy(c => c).Select(c => c.Count() / 2).Sum();
		}

		public int PowerRanger(int power, int min, int max)
		{
			int counter = 0;
			for (int i = min; i <= max; i++)
			{
				if (Math.Pow(i, 1.0 / power) % 1 == 0) counter++;
			}
			return counter;
		}

		public bool SmoothSentences(string sentence)
		{
			return Regex.Matches(sentence, @"([a-z]) (?!\1)", RegexOptions.IgnoreCase).Count == 0;
		}

		public bool ParselTongue(string sentence)
		{
			return sentence.ToLower().Split().Count(x => x.Contains("s") && !x.Contains("ss")) == 0;
		}

		public string TwelveVs24(string time)
		{
			if (time.Contains("am") || time.Contains("pm"))
			{
				return DateTime.Parse(time).ToString("H:mm");
			}

			return DateTime.Parse(time).ToString("h:mm tt").ToLower();
		}

		public bool SameLetterPatterns(string wordOne, string wordTwo)
		{
			if (wordOne.Length != wordTwo.Length) return false;
			for (int i = 0; i < wordOne.Length; i++)
			{
				if (wordOne.IndexOf(wordOne.Substring(i, 1), i + 1) != wordTwo.IndexOf(wordTwo.Substring(i, 1), i + 1)) return false;
			}
			return true;
		}

		public bool PalindromeDescendent(int number)
		{
			var temp = number.ToString();
			for (int i = 0; i < temp.Length; i++)
			{
				if (temp.Length > 4)
				{
					if (Convert.ToInt32(temp[0].ToString()) + Convert.ToInt32(temp[1].ToString()) <= 9)
						temp = (Convert.ToInt32(temp[0].ToString()) + Convert.ToInt32(temp[1].ToString())).ToString() + temp.Substring(2, temp.Length - 4) + (Convert.ToInt32(temp[temp.Length - 1].ToString()) + Convert.ToInt32(temp[temp.Length - 2].ToString())).ToString();
					else
						return false;
				}
				if (temp.Length <= 4 && temp.Length > 2)
					temp = (Convert.ToInt32(temp[0].ToString()) + Convert.ToInt32(temp[1].ToString())).ToString() + (Convert.ToInt32(temp[temp.Length - 1].ToString()) + Convert.ToInt32(temp[temp.Length - 2].ToString())).ToString();
			}
			return temp[0] == temp[1];
		}
	}
}
