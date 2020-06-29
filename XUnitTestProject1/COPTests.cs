using Xunit;
using COPStarter;

namespace XUnitTestProject1
{
	public class COPTests
	{
		COPMethods cs = new COPMethods();

		// Challenge 1 - Shuffle the name
		// You need to create a function that takes a string (of a person's first and last name)
		// Return the string with first and last name swapped 
		// E.g. "Ruha Bashir" => "Bashir Ruha"

		[Theory]
		[InlineData("Ruha Bashir", "Bashir Ruha")]
		[InlineData("Seymour Butts", "Butts Seymour")]
		[InlineData("James Sam", "Sam James")]
		[InlineData("Donald Trump", "Trump Donald")]

		public void Shuffle_The_Name(string names, string answer)
		{
			var result = cs.ShuffleTheName(names);

			Assert.Equal(answer, result);
		}

		// Challenge 2 - Count Syllables
		// You need to create a function that counts the number of syllables a word has
		// Each syllable is separated with a dash -
		// Syllable is a word separated by dash -
		// Return number of syllables
		// E.g. "buf-fet" => 2
		[Theory]
		[InlineData("buf-fet", 2)]
		[InlineData("beau-ti-ful", 3)]
		[InlineData("mon-u-men-tal", 4)]
		[InlineData("on-o-mat-o-poe-ia", 6)]
		public void Count_Sylabbles(string word, int answer)
		{
			var result = cs.CountSyllables(word);

			Assert.Equal(answer, result);
		}

		// Challenge 3 - Xs and Os, Nobody Knows 
		// You need to create a function that takes a string and checks if it has same number of x's and o's
		// Return true if same number E.g. ("ooxx") => true
		// Return false if not same number E.g. ("xooxx") => false
		// Return true if there are no x and o
		// Must be case insensitive
		[Theory]
		[InlineData("ooxx", true)]
		[InlineData("xooxx", false)]
		[InlineData("ooxXm", true)]
		[InlineData("zpzpzp", true)]
		[InlineData("zzoo", false)]
		public void X_And_O(string xAndO, bool answer)
		{
			var result = cs.XsAndOs(xAndO);

			Assert.Equal(answer, result);
		}

		// Challenge 4 - Positive Count / Negative Sum
		// Create a function that takes an array of positive and negative numbers
		// Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers
		// 0 is not positive
		[Theory]
		[InlineData(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }, new[] { 10, -65 })]
		[InlineData(new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 }, new[] { 7, -252 })]
		[InlineData(new double[] { 91, -4, 80, -73, -28 }, new[] { 2, -105 })]

		public void Count_Positive_Negative(double [] numbers, int [] answers)
		{
			var result = cs.CountPositiveNegative(numbers);

			Assert.Equal(answers, result);
		}

		// Challenge 5 - Strange pair
		// You need to create a function that checks whether a pair of strings is strange pair or not
		// A pair of strings is a strange pair if both are the following are true:
		// 1) The 1st string's first letter = 2nd string's last letter
		// 2) The 1st string's last letter = 2nd string's first letter
		// Return true is it is a strange pair - E.g. ("ratio", "orator") => true
		// Return false if it is not a strange pair - E.g. ("bush", "hubris") => false
		// It should work on a pair of empty strings 
		[Theory]
		[InlineData("ratio", "orator", true)]
		[InlineData("sparkling", "groups", true)]
		[InlineData("bush", "hubris", false)]
		[InlineData("", "", true)]
		public void Strange_Pair(string one, string two, bool answer)
		{
			var result = cs.StrangePair(one, two);

			Assert.Equal(answer, result);
		}

		// Challenge 6 - Prime number
		// You need to create a function that outputs true if a number is prime, and false otherwise
		// A prime number has no other factors except 1 and itself
		// 1 is not considered a prime number
		[Theory]
		[InlineData(31, true)]
		[InlineData(18, false)]
		[InlineData(11, true)]
		public void Prime_Number(int number, bool answer)
		{
			var result = cs.PrimeNumber(number);

			Assert.Equal(answer, result);
		}

		// Challenge 7 - The  Museum of incredibly dull things
		// You need to create a function that takes in an array of integers and removes the smallest one
		// Return the array without the smallest number E.g. ([1, 2, 3, 4, 5] ) => [2, 3, 4, 5]
		// Don't change the order of array
		// If array is empty then return empty array
		// If there are multiple items with the same value, remove item with lower index E.g. ([2, 2, 1, 2, 1]) => [2, 2, 2, 1]
		[Theory]
		[InlineData(new[] { 1, 2, 3, 4, 5 }, new[] {2, 3, 4, 5})]
		[InlineData(new[] { 5, 3, 2, 1, 4 }, new[] { 5, 3, 2, 4 })]
		[InlineData(new[] { 2, 2, 1, 2, 1 }, new[] { 2, 2, 2, 1 })]
		[InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 2, 3, 4, 5, 6 })]
		public void Remove_Lowest(int [] array, int [] answer)
		{
			var result = cs.RemoveLowest(array);

			Assert.Equal(answer, result);
		}

		// Challenge 8 - Convert “Zero” and “One” to “1” and “0” 
		// You need to create a function that takes a string as an argument
		// Return a string containing 1s and 0s based on the string argument's words
		// If any word in the argument is not equal to "zero" or "one" (case insensitive), you should ignore it
		// The returned string's length should be a multiple of 8, if the string is not a multiple of 8 you should remove the numbers in excess
		[Theory]
		[InlineData("zero one zero one zero one zero one", "01010101")]
		[InlineData("Zero one zero ONE zero one zero one", "01010101")]
		[InlineData("zero one zero one zero one zero one one two", "01010101")]
		[InlineData("zero one zero one zero one zero three", "")]
		[InlineData("one one", "")]
		public void ConvertZeroAndOne(string words, string answer)
		{
			var result = cs.ConvertZeroAndOne(words);

			Assert.Equal(answer, result);
		}

		// Challenge 9 - Sock pairs
		// Joseph is in the middle of packing for a vacation
		// He's having trouble finding all his socks
		// You need to create a function that returns the number of sock pairs he has
		// A sock pair consists of two of the same letter - E.g. AA
		// The socks are represented as an unordered sequence
		// If given an empty string (no socks in the drawer), return 0.
		// There can be multiple pairs of the same type of sock, such as two pairs of CC
		[Theory]
		[InlineData("AA", 1)]
		[InlineData("ABABC", 2)]
		[InlineData("CABBACCC", 4)]
		public void Sock_Pairs(string socks, int answer)
		{
			var result = cs.SockPairs(socks);

			Assert.Equal(answer, result);
		}

		// Challenge 10 - Power ranger
		// You need to create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive
		// Remember that the range is inclusive
		// a < b will always be true
		[Theory]
		[InlineData(2, 49, 65, 2)]
		[InlineData(3, 1, 27, 3)]
		[InlineData(10, 1, 5, 1)]
		[InlineData(5, 31, 33, 1)]
		[InlineData(4, 250, 1300, 3)]
		public void Power_Ranger(int power, int min, int max, int answer)
		{
			var result = cs.PowerRanger(power, min, max);

			Assert.Equal(answer, result);
		}

		// Challenge 11 - Smooth Sentences
		// You need create a function that takes a sentence as an argument and checks whether that is a smooth sentence or not
		// A smooth sentence is one where the last letter of each word is ideantical to the first letter of the following word
		// Return true if sentence is smooth
		// Return false if sentence is not smooth
		// E.g. "Carlos swam masterfully"
		[Theory]
		[InlineData("Marta appreciated deep perpendicular right trapezoids", true)]
		[InlineData("Someone is outside the doorway", false)]
		[InlineData("She eats super righteously", true)]
		public void Smooth_Sentences(string sentence, bool answer)
		{
			var result = cs.SmoothSentences(sentence);

			Assert.Equal(answer, result);
		}

		// Challenge 12 - Parseltongue      
		// Hermione has come up with a precise formula for determining whether or not a phrase was ssspoken by a parssseltongue
		// You need to create a function that takes in a sentence and determines whether the sentence is parsel tongue or not
		// Each word in a sssentence must contain either:
		// 1) At least 2 instances of the letter "s" - E.g. must be together ss
		// 2) Zero instances of the letter "s"
		// Return true if sentence is parsel tongue
		// Return false if sentence is not parsel tongue
		// There should be no words with only one instance of the letter "s" - E.g. She ssselects to eat that apple
		[Theory]
		[InlineData("Sshe ssselects to eat that apple", true)]
		[InlineData("She ssselects to eat that apple", false)]
		[InlineData("Beatrice samples lemonade", false)]
		[InlineData("You ssseldom sssspeak sso boldly, ssso messmerizingly", true)]

		public void Parsel_Tongue(string sentence, bool answer)
		{
			var result = cs.ParselTongue(sentence);

			Assert.Equal(answer, result);
		}

		// Challenge 13 - 12 vs 24 Hours
		// You need to create a function that converts 12-hour time to 24-hour time or vice versa
		// Return the output as a string
		// A 12-hour time input will be denoted with an am or pm suffix
		// A 24-hour input time contains no suffix
		[Theory]
		[InlineData("12:00 am", "0:00")]
		[InlineData("6:20 pm", "18:20")]
		[InlineData("21:00", "9:00 pm")]
		[InlineData("5:05", "5:05 am")]
		public void Twelve_Vs_24(string time, string answer)
		{
			var result = cs.TwelveVs24(time);

			Assert.Equal(answer, result);
		}

		// Challenge 14 - Same letter patterns
		// You need to create a function that returns true if two strings share the same letter pattern, and false otherwise
		// E.g. ("ABAB", "CDCD") => true
		[Theory]
		[InlineData("ABAB", "CDCD", true)]
		[InlineData("ABCBA", "BCDCB", true)]
		[InlineData("FFGG", "CDCD", false)]
		[InlineData("FFFF", "ABCD", false)]
		public void Same_Letter_Patterns(string wordOne, string wordTwo, bool answer)
		{
			var result = cs.SameLetterPatterns(wordOne, wordTwo);

			Assert.Equal(answer, result);
		}

		// Challenge 15 - Palindrome Descendant (Bonus)
		// You need to create a function that takes an integer and returns true if the number itself is a palindrome or any of its descendants down to 2 digits (a 1-digit number is trivially a palindrome)
		// A number may not be a palindrome, but its descendant can be
		// A number's direct child is created by summing each pair of adjacent digits to create the digits of the next number
		// For instance, 123312 is not a palindrome, but its next child 363 is, where: 3 = 1 + 2; 6 = 3 + 3; 3 = 1 + 2
		// Numbers will always have an even number of digits
		[Theory]
		[InlineData(11211230, false)]
		[InlineData(13001120, true)]
		[InlineData(23336014, true)]
		[InlineData(11, true)]
		public void Palindrome_Descendant(int number, bool answer)
		{
			var result = cs.PalindromeDescendent(number);

			Assert.Equal(answer, result);
		}
	}
}
