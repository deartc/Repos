using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        string diet = args[0];
        string caloriesArgument = args[1];
        int calories = 0;


        if (int.TryParse(caloriesArgument, out caloriess))
        {
            Console.WriteLine(diet + " will have " + calories + " calories in diet!");
        }
        else
        {
            Console.WriteLine("We were unable to determine the number of calories in diet, try again.");
        }
    }
}
using System;
	

	public class Program
{
    static void Main(string[] args)
    {
        string menu = args[0];
        string calorieArgument = args[1];
        int calories = 0;


        if (int.TryParse(calorieArgument, out calories))
        {
            Console.WriteLine(venue + " will have " + calories + " calories in diet!");
        }
        else
        {
            Console.WriteLine("We were unable to determine the number of calories in diet, try again.");
        }
    }
}

