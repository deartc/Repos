namespace Employees
{
    internal partial class Employee
    {
        class Program
        {
            static void Main(string[] args)
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

                    Console.WriteLine("1 : : opitins " + "\n2 : : employee" + "\n3 : : exit");//display user

                    x = int.Parse(Console.ReadLine());


                    if (x == 1)
                    {



                    // Console.WriteLine("Enter  date in DD/MM/YYYY format");  //and date.
                    // DateTime aDay = DateTime.Parse(Console.ReadLine());//enter date today
                    // Console.WriteLine("Welcome to the company : ");private static Employee (DateTime birthday) => this.birthday = birthday;

        public DateTime birthday Update(int salary, DateTime birthday)
 {
            Salary = salary;
            Birthday =  birthday;
            return "\"Welcome to the company, "employee"! Your salary is "salary" and your birthday is "birthday".\"";
            }


        }


    }
}
