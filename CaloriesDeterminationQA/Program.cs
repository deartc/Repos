using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        // Calorie Determination
        Console.WriteLine("Calories in Fats Project!");
        using System;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

public class Program
{
    static void Main(string[] args, int fats)
    {
        string venue = args[0];
        string fatsArgument = args[1];
        int fats = 0;

        if (int.TryParse(fatsArgument, out fats))
        {
            Console.WriteLine(venue + " will have " + fats + " fats in food!");

            if (fats == 0)
            {
                Console.WriteLine("There will be fats.");
            }
            else if (fats == 1)
            {
                Console.WriteLine("It's going to be a fantastic meal tonight!");
            }
            else
            {
                Console.WriteLine("It will be a healthy meal!");
            }
        }
        else
        {
            Console.WriteLine("We were unable to determine the number of fats, try again.");
        }
    }
}

