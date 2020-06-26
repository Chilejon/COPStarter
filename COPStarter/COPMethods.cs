using System;

namespace COPStarter
{
	public class COPMethods
	{
		public int calculateSum(int number1, int number2)
		{
			return number1 + number2;
		}

		public int countVowels(string Sentence)
		{
			string[] letters = Sentence.Split("");
			int vowelCount = 0;

			foreach (var item in Sentence)
			{
				if (item.ToString() == "a" || item.ToString() == "e" || item.ToString() == "i" || item.ToString() == "o" || item.ToString() == "u")
				{
					vowelCount = vowelCount + 1;
				}
			}

			return vowelCount;
		}

		public int milesToKM(int Miles)
		{
			double km = Miles * 1.609344;

			return Convert.ToInt32(km);
		}

		public bool isItEqualSlces(int totalSlices, int numberOfRecipients, int slicesEach)
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

		public string convertLyrics(string fullLyrics)
		{
			string[] arrayOfLyrics = fullLyrics.Split(" ");

			string justTheFirst = "";

			foreach (var word in arrayOfLyrics)
			{
				if (!string.IsNullOrEmpty(word))
				{
					justTheFirst += word.ToUpper().Substring(0, 1) + " ";
				}
			}

			return justTheFirst.Trim();
		}








	}
}
