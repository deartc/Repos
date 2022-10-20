namespace cargoItems
{
    public class cargoItemsClass1
    {
        public struct Cargo
        {
            public string Name { get; set; }
            public int Size { get; set; }
            public int Weight { get; set; }

            public void ReportLoadingAttempt(bool succeeded, IVehicle vehicle)
            {
                if (succeeded) Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);
                else Console.WriteLine(Name + " NOT LOADED onto " + vehicle.Name);
            }
        }

        public interface IVehicle
        {
            string Name { get; }

            int Wheels { get; }
            int Doors { get; }
            int Seats { get; }

            string Specs { get; }
            Cargo LoadedCargo { get; set; }
        }

        public static string GetSpecsStringForVehicle(IVehicle vehicle)
        {
            return "This vehicle has " + vehicle.Wheels + " wheels, can seat " + vehicle.Seats + " " + (vehicle.Seats == 1 ? "person" : "people") + " and has " + vehicle.Doors + " doors";
        }

        static void TestVehicle(IVehicle vehicleToTest, Cargo[] cargos)
        {
            //Specify which vehicle we are testing
            Console.WriteLine(vehicleToTest.Name + ":");
            //Write out the specs for this car
            Console.WriteLine(vehicleToTest.Specs);

            foreach (Cargo cargoToTryLoading in cargos)
            {
                vehicleToTest.LoadedCargo = cargoToTryLoading;
            }
            Console.WriteLine("FINAL CARGO for " + vehicleToTest.Name + ": " + vehicleToTest.LoadedCargo.Name);
            Console.WriteLine("");
        }

        public static void Main()
        {
            //Cargo list to test
            Cargo[] cargos = new Cargo[]
            {
            new Cargo() { Name = "Backpack", Size = 5, Weight = 5 },
            new Cargo() { Name = "Bike", Size = 20, Weight = 25 },
            new Cargo() { Name = "Camping gear", Size = 45, Weight = 35 },
            new Cargo() { Name = "Shopping centre delivery", Size = 120, Weight = 150 }
            };

        }
    }
}