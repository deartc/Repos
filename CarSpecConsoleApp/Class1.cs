using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpecConsoleApp
{
   
class CarDetail
{
    private:
    double miles;
    double gallons;

    public class Car
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public decimal MilesPerGallon { get; set; }
        public decimal GasTankCapacity { get; set; }




        private:
    double miles;
        double gallons;
        public:
    car(double m, double g) : miles(m), gallons(g) { }
        double getMPG(void) const {return miles / gallons;}
    double getMiles(void) const {return miles;}
double getGallons(void) const {return gallons;}
};

car cars[6] ={
    car(240.5, 16.4),
    car(300.0, 15.6),
    car(320.5, 17.2),
    car(280.7, 15.4),
    car(190.7, 13.7),
    car(265.3, 16.9)};

int main()
{
    int i;
    cout << "Index\tMiles\tGallons\tMPG\n";
    for (i = 0; i < 6; i++)
    {
        cout << i << "\t" << cars[i].getMiles() << "\t" << cars[i].getMiles() << "\t" << cars[i].getMPG() << endl;
    }
    char z; cin >> z;
}
  using System;

        static void Main(string[] args)
{
    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;

    Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
    Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
    Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
    Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
}
    }
}
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
    MilesPerGallon = decimal.Parse(MilesPerGallon,
};

Console.WriteLine($"Make of car, {car.Make}! " +
$"Your model is {car.Model} " +
$"and your WasModelMadeInYear  is {car.WasModelMadeInYear.ToShortDateString()}.");
