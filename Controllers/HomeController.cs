using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerPlatform.Models;
using Microsoft.AspNetCore.Authorization;

using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using CustomerPlatform.Areas.Identity.Data;
using System.Text;
using System.Net;
using System.IO;

namespace CustomerPlatform.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Interventions()
        {

            // Get Batteries data
            string url1 = "https://restapisaadeddine.azurewebsites.net/api/Batteries";

            WebRequest request = HttpWebRequest.Create(url1);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string Customer_JSON_List = reader.ReadToEnd();
            List<Batteries> BList = new List<Batteries>();

            List<Batteries> objResponse =
    JsonConvert.DeserializeObject<List<Batteries>>(Customer_JSON_List);
            // if (objResponse != null)
            // {
            //     int count = 0;
            //     foreach (Batteries element in objResponse)
            //     {
            //         count++;

            //         Console.WriteLine($"Element #{count}: " + element.id);
            //     }


            //     Console.WriteLine("------------ yahoo -------------" + objResponse.Count());
            // }


            // get all columns

            string url2 = "https://restapisaadeddine.azurewebsites.net/api/Columns/";

            WebRequest request2 = HttpWebRequest.Create(url2);
            WebResponse response2 = request2.GetResponse();
            StreamReader reader2 = new StreamReader(response2.GetResponseStream());
            string JSON_List2 = reader2.ReadToEnd();
            List<Column> CList = new List<Column>();

            List<Column> objResponse2 = JsonConvert.DeserializeObject<List<Column>>(JSON_List2);
            // Get all Elevators
            string url3 = "https://restapisaadeddine.azurewebsites.net/api/Elevators";

            WebRequest request3 = HttpWebRequest.Create(url3);
            WebResponse response3 = request3.GetResponse();
            StreamReader reader3 = new StreamReader(response3.GetResponseStream());
            string JSON_List3 = reader3.ReadToEnd();
            List<Elevator> EList = new List<Elevator>();

            List<Elevator> objResponse3 = JsonConvert.DeserializeObject<List<Elevator>>(JSON_List3);
            if (objResponse3 != null)
            {
                int count = 0;
                foreach (Elevator e in objResponse3)
                {
                    count++;

                    Console.WriteLine($"Element #{count}: " + e.id);
                }
            }

            return View();
        }

        public class Batteries
        {
            public int id { get; set; }
            public int buildingId { get; set; }
            public object employeeId { get; set; }
            public string batteryType { get; set; }
            public string batteryStatus { get; set; }
            public DateTime dateOfCommissioning { get; set; }
            public DateTime dateOfLastInspection { get; set; }
            public string certificateOfOperations { get; set; }
            public string information { get; set; }
            public string notes { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class Root
        {
            public List<Batteries> MyArray { get; set; }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Column
        {
            public int id { get; set; }
            public int batteryId { get; set; }
            public string columnType { get; set; }
            public string columnStatus { get; set; }
            public int numberOfFloorsServed { get; set; }
            public string information { get; set; }
            public string notes { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class Root2
        {
            public List<Column> MyArray { get; set; }
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Elevator
        {
            public int id { get; set; }
            public int columnId { get; set; }
            public string serialNumber { get; set; }
            public string elevatorModel { get; set; }
            public string elevatorType { get; set; }
            public string elevatorStatus { get; set; }
            public DateTime dateOfCommissioning { get; set; }
            public DateTime dateOfLastInspection { get; set; }
            public string certificateOfInspection { get; set; }
            public string information { get; set; }
            public string notes { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
