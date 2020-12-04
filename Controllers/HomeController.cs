using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

using System.Text;
using System.Net;
using System.IO;
using CustomerPlatform.Areas.Identity.Data;
using CustomerPlatform.Models;

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
            // https://restapisaadeddine.azurewebsites.net/api/Batteries/{email}/costumer
            // https://restapisaadeddine.azurewebsites.net/api/Columns/{email}/column
            // https://restapisaadeddine.azurewebsites.net/api/Elevators/{email}/elevator
            // https://restapisaadeddine.azurewebsites.net/api/BuildingsOff/{email}/buildings
            // https://restapisaadeddine.azurewebsites.net/api/Adresses/{email}/address
            // Get Batteries data


            string template1 = "https://restapisaadeddine.azurewebsites.net/api/Batteries/{0}/costumer";

            string data = User.Identity.Name;
            string url1 = string.Format(template1, data);

            WebRequest request = HttpWebRequest.Create(url1);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string Customer_JSON_List = reader.ReadToEnd();

            List<Batteries> objResponse =
    JsonConvert.DeserializeObject<List<Batteries>>(Customer_JSON_List);

            // Get columns
            string template2 = "https://restapisaadeddine.azurewebsites.net/api/Columns/{0}/column";

            string url2 = string.Format(template2, data);

            WebRequest request2 = HttpWebRequest.Create(url2);
            WebResponse response2 = request2.GetResponse();
            StreamReader reader2 = new StreamReader(response2.GetResponseStream());
            string JSON_List2 = reader2.ReadToEnd();

            List<Column> objResponse2 = JsonConvert.DeserializeObject<List<Column>>(JSON_List2);

            // Get all Elevators
            string template3 = "https://restapisaadeddine.azurewebsites.net/api/Elevators/{0}/elevator";

            string url3 = string.Format(template3, data);

            WebRequest request3 = HttpWebRequest.Create(url3);
            WebResponse response3 = request3.GetResponse();
            StreamReader reader3 = new StreamReader(response3.GetResponseStream());
            string JSON_List3 = reader3.ReadToEnd();

            List<Elevator> objResponse3 = JsonConvert.DeserializeObject<List<Elevator>>(JSON_List3);


            // Get Buildings for this USER
            string template4 = "https://restapisaadeddine.azurewebsites.net/api/BuildingsOff/{0}/buildings";


            string url4 = string.Format(template4, data);

            WebRequest request4 = HttpWebRequest.Create(url4);
            WebResponse response4 = request4.GetResponse();
            StreamReader reader4 = new StreamReader(response4.GetResponseStream());
            string JSON_List4 = reader4.ReadToEnd();

            List<Buildings> objResponse4 = JsonConvert.DeserializeObject<List<Buildings>>(JSON_List4);
            if (objResponse4 != null)
            {
                int count = 0;
                foreach (Buildings e in objResponse4)
                {
                    count++;

                    Console.WriteLine($"Element #{count}: " + e.administratorFullName);
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

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Buildings
        {
            public int id { get; set; }
            public int customerId { get; set; }
            public int adminContactId { get; set; }
            public int technicalContactId { get; set; }
            public string administratorFullName { get; set; }
            public string administratorEmail { get; set; }
            public string administratorPhoneNumber { get; set; }
            public string technicalContactFullName { get; set; }
            public string technicalContactEmail { get; set; }
            public string technicalContactPhone { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public int buildingDetailId { get; set; }
            public int addressId { get; set; }
            public object adminContact { get; set; }
            public object technicalContact { get; set; }
            public List<object> addresses { get; set; }
            public List<object> buildingDetails { get; set; }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
