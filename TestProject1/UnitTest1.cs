

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public double MilesPerGallon { get; set; }
        public decimal GasTankCapacity { get; set; }

        public Car()
        {
            Make = "";
            Model = "";
            MilesPerGallon = 0.00M;
            GasTankCapacity = 0.00M;

            public Car (string make, string model, double milesPerGallon, double gasTankCapacity)
            Make = make;
            Model = model;
            MilesPerGallon = milesPerGallon;
            GasTankCapacity = gasTankCapacity;





        }

    }
}
