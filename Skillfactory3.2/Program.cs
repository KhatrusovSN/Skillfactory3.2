using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		Console.Write("Enter your age: ");
		byte age = checked((byte)int.Parse(Console.ReadLine()));
		Console.WriteLine($"Your name is {name} and age is {age} ");
        Console.WriteLine("What is your favorite day a week?");
		DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day of week: " + day);
	}
}
