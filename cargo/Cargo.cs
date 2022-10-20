namespace cargo
{

    namespace Vehicle
    {
        public partial class CargoItem
        {
            public struct Cargo
            {
                string ;

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
                    vehicle.LoadCargo = new Cargo();
                }
            }




        }
    }