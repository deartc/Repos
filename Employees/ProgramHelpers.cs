namespace Employees
{
    internal static class ProgramHelpers
    {
        private const bool V = true;

        static void Main(string[] args, int v1)
        {


            DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);//the date
            int year = myDate.Year; // 2015  
            int month = myDate.Month; //12  
            int day = myDate.Day; // 25  
            int hour = myDate.Hour; // 10  
            int minute = myDate.Minute; // 30  
            int second = myDate.Second; // 45  
            int weekDay = (int)myDate.DayOfWeek;


            TGCEmployeeArray empArray = new TGCEmployeeArray();  //Creating an empty list of employees.


            int x;
            do
            {
                int v = v1;
                x = v;
            } while (V)

    {

            }
            static int NewMethod()
            {
                int x;
                {

                    Console.WriteLine("1 : : options " + "\n2 : : employee" + "\n3 : : exit");//display user

                    x = int.Parse(Console.ReadLine());


                    if (x == 1)


                    }

                return x;
            }
    }
}