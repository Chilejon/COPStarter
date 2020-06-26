using System;
using COPStarter;

namespace ConsoleApp1
{
	class Program
	{
		

		static void Main(string[] args)
		{
			COPMethods cs = new COPMethods();

			string lyrics = Console.ReadLine();

			
			Console.WriteLine(cs.convertLyrics(lyrics));

		}
	}
}
