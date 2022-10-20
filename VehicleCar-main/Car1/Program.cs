// See https://aka.ms/new-console-template for more information

using Car1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing for gas and flat tires!");

        Console.WriteLine("Cannot drive, out of gas.”.\r\n");
        var gasInput = Console.ReadLine();

        Console.WriteLine("Cannot drive due to flat tire");
        var carsInput = Console.ReadLine();


}



        DateTime birthday;

        while (!DateTime.TryParse(birthdayInput, out birthday))
        {
            Console.WriteLine("Invalid birthday, please try again");
            birthdayInput = Console.ReadLine();
        }

        Console.WriteLine("Please enter your gas");
        var gas = Console.ReadLine();

        var Car = new Car
        {
            Car = cars,
            Birthdy = birthday,
            Gas = decimal.Parse(gas)
        };

        Console.WriteLine($"Welcome to the co, {car.Name}! " +
            $"Your Gas is {car.Gas} " +
          


        
    }
}