using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParametersConsoleApp
{


    
using Parameters;

Console.WriteLine("Testing for gas and flat tires!");

Console.WriteLine(" “Cannot drive, out of gas.”.\r\n");
var gasInput = Console.ReadLine();

Console.WriteLine("Cannot drive due to flat tire");
var TireInput = Console.ReadLine();

DateTime WasModelMadeInYear;

while (!DateTime.TryParse(Input WasModelMadeInYear, out WasModelMadeInYear))
{
    Console.WriteLine("Invalid , no data is available for years before 1995");
    WasModelMadeInYear Console.ReadLine();
}

Console.WriteLine("Please enter your make");
var make = Console.ReadLine();

var model = new model
{
    Make = make,
    WasModelMadeInYear = year,
    MilesPerGallon = decimal.Parse(milesPerGallon,
};

Console.WriteLine($"Make of car, {car.Make}! " +
$"Your model is {car.Model} " +
$"and your WasModelMadeInYear  is {car.WasModelMadeInYear.ToShortDateString()}.");
