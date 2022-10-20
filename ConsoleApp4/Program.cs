// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using Vehicle;
using static MyApplication.CarDetail;
using car = Vehicle.car;

namespace Vehicle
{
    public class car
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public decimal MilesPerGallon { get; set; }
        public decimal GasTankCapacity { get; set; }
        public double GasLevel { get; set; }
        public decimal public struct Cargo
        {
            string name;

            public string Name
            {
                get
                {
                    if (EmptyCargo) return "<NO CARGO>";
                    else return name;
                }
                set { name = value; }
            }

            bool EmptyCargo { get { return string.IsNullOrWhiteSpace(name); } }

            public int Size { get; set; }
            public int Weight { get; set; }

            public void ReportLoadingAttempt(bool succeeded, IVehicle vehicle)
            {
                if (succeeded)
                {
                    if (EmptyCargo) Console.WriteLine("No cargo in " + vehicle.Name);
                    else Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);
                }
                else Console.WriteLine(Name + " NOT LOADED onto " + vehicle.Name);
            }

            public static void Eject(IVehicle vehicle)
            {
                vehicle.LoadedCargo = new Cargo();
            }
        }



