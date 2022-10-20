using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;


namespace VehicleAPITest2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Task t1 = Task.Run(() =>
              {
                 GetRequest("https://vpic.nhtsa.dot.gov/api/vehicles/IsValidModelForMakeAsync/Honda?format=json");

              });
              t1.Wait();
              Console.WriteLine("Main Thread Completed");
              Console.ReadLine();*/

            /* Task t1 = new Task(GetRequest);
            t1.Start();
            Console.WriteLine("Main Thread Completed");
            Console.ReadLine();*/

            GetRequest("https://vpic.nhtsa.dot.gov/api/vehicles/IsValidModelForMakeAsync/Honda?format=json");
            Console.ReadKey();
        }

        async static void GetRequest(string url)
        {
            //string url = "https://vpic.nhtsa.dot.gov/api/vehicles/IsValidModelForMakeAsync/Honda?format=csv";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        var vehrec = JObject.Parse(mycontent);

                       

                        Console.WriteLine(vehrec);

                        
                    }

                }

            }



        }






    }









}
