
using Vehicle;

namespace Vehicle
{
    public class Car
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public decimal MilesPerGallon { get; set; }
        public decimal GasTankCapacity { get; set; }

        public Car()
        {
            Make = "";
            Model = "";
            MilesPerGallon = 0.00M;
            GasTankCapacity = 0.00M;

            public Car (string a, string b, decimal c, decimal d)
            Make = a;
            Model = b;
            MilesPerGallon = c;
            GasTankCapacity = d;





        }

    }
}


using System;

namespace MyApplication

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

