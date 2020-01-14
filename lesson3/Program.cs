using System;

class Program
{
	static void Main()
	{
	appBegin:
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Lesson 3");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		 
		123123123123123213


		Console.WriteLine();
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Выйти из программы? [y/n]:");
		if (Console.ReadLine().Trim().ToLower() == "n") { goto appBegin; }
	}
}