using Xunit;
using COPStarter;
using System.Reflection.Metadata;

namespace XUnitTestProject1
{
	public class COPTests
	{
		COPMethods cs = new COPMethods();

		// you need to add 2 numbers together,
		// 2+2 = 4 
		// 2+3 != 4
		[Fact]
		public void Add_two_numbers()
		{
			int number1 = 2;
			int number2 = 4;
			int sum;

			sum = cs.calculateSum(number1, number2);

			Assert.Equal(6, sum);
		}

		[Theory]
		[InlineData("aeiou", 5)]
		[InlineData("this is an other test and it has some cowels in it", 15)]
		public void Count_vowels_in_a_sentance(string input, int vowelCount)
		{
			string sentence = input;
			int sum;

			sum = cs.countVowels(sentence);

			Assert.Equal(vowelCount, sum);
		}

		[Theory]
		[InlineData(6, 10)]
		[InlineData(60, 97)]
		public void convert_miles_to_the_nearest_km(int miles, int km)
		{
			int answerKm = cs.milesToKM(miles);

			Assert.Equal(km, answerKm);
		}

		[Theory]
		[InlineData(10, 5, 2, true)]
		[InlineData(100, 5, 2, true)]
		[InlineData(10, 9, 2, false)]
		[InlineData(4, 3, 2, false)]
		[InlineData(4, 0, 2, true)]
		public void check_even_slices(int totalSlices, int numberOfRecipients, int slicesEach, bool outcome)
		{
			bool result = cs.isItEqualSlces(totalSlices, numberOfRecipients, slicesEach);

			Assert.Equal(outcome, result);
		}
	}
}
