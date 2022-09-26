using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarParametersConsoleApp
{
    internal class CarParameters
    {
        Console.WriteLine("Please enter your make");
var make = Console.ReadLine();

        var model = new model
        {
            Make = make,
            WasModelMadeInYear = year,
            MilesPerGallon = decimal.Parse(MilesPerGallon,
        };
        private static ReadOnlySpan<char> MilesPerGallon;

        public object Model { get => model; set => model = value; }
        public object Model1 { get => model; set => model = value; }

        public CarParameters(object make, object model)
        {
            this.make = make;
            this.Model = model;
        }

        public CarParameters(object make) => this.make = make ?? throw new ArgumentNullException(nameof(make));

        Console.WriteLine($"Make of car, {car.Make}! " +
$"Your model is {car.Model} " +
$"and your WasModelMadeInYear  is {car.WasModelMadeInYear.ToShortDateString()}.");
}
}