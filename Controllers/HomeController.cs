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

            // Get addresses buildings for this USER
            string template5 = "https://restapisaadeddine.azurewebsites.net/api/Adresses/{0}/address";


            string url5 = string.Format(template5, data);

            WebRequest request5 = HttpWebRequest.Create(url5);
            WebResponse response5 = request5.GetResponse();
            StreamReader reader5 = new StreamReader(response5.GetResponseStream());
            string JSON_List5 = reader5.ReadToEnd();

            List<Address> objResponse5 = JsonConvert.DeserializeObject<List<Address>>(JSON_List5);
            if (objResponse5 != null)
            {
                int count = 0;
                foreach (Address e in objResponse5)
                {
                    count++;

                    Console.WriteLine($"Element #{count}: " + e.city + " ::" + data);
                }
            }

            // get Customer Data
            // Get addresses buildings for this USER
            string template6 = " https://restapisaadeddine.azurewebsites.net/api/Customers/{0}";


            string url6 = string.Format(template6, data);

            WebRequest request6 = HttpWebRequest.Create(url6);
            WebResponse response6 = request6.GetResponse();
            StreamReader reader6 = new StreamReader(response6.GetResponseStream());
            string JSON_List6 = reader6.ReadToEnd();

            List<Customer> objResponse6 = JsonConvert.DeserializeObject<List<Customer>>(JSON_List6);

            /* *
       * ViewBag is a property – considered a dynamic object – that enables you * to share values dynamically between the controller and view within ASP.* NET MVC applications. */

            // Send data via ViewBag

            ViewBag.Customeremail += $"<div> {data}</div>";
            foreach (Customer e in objResponse6)
            {
                ViewBag.CustomerfullName += $"<div>{e.companyContactFullName} </div>";
                ViewBag.CustomercompanyName += $"<div>{e.companyName} </div> ";
                ViewBag.CustomercompanyContactPhone += $"<div>{e.companyName} </div>";
                ViewBag.CustomercompanyDescription += $"<div>{e.companyName} </div>";
                ViewBag.CustomertechnicalAuthorityPhoneNumber += $"<div>{e.companyName} </div>";
                ViewBag.CustomertechnicalManagerEmailService += $"<div>{e.companyName} </div>";
                ViewBag.CustomerId = $"<div>{e.userId}</div>";

            }

            foreach (Batteries e in objResponse)
            {
                ViewBag.BatteriesId += $"<div>{e.id} </div> ";
                ViewBag.BatteriesbuildingId += $"<div>{e.buildingId} </div> ";
                ViewBag.BatteriesemployeeId += $"<div>{e.employeeId} </div> ";
                ViewBag.BatteriesbatteryType += $"<div>{e.batteryType} </div> ";
                ViewBag.BatteriesbatteryStatus += $"<div>{e.batteryStatus} </div> ";
                ViewBag.BatteriesdateOfCommissioning += $"<div>{e.dateOfCommissioning} </div> ";
                ViewBag.BatteriesdateOfLastInspection += $"<div>{e.dateOfLastInspection} </div>";
                ViewBag.BatteriescertificateOfOperations += $"<div>{e.certificateOfOperations} </div>";
                ViewBag.Batteriesnotes += $"<div>{e.notes} </div>";
                ViewBag.Batteriesinformation += $"<div>{e.information} </div > ";

            }
            foreach (Column e in objResponse2)
            {
                ViewBag.ColumnId += $"<div>{e.id} </div>";
                ViewBag.ColumnbatteryId += $"<div>{e.batteryId} </div> ";
                ViewBag.ColumncolumnType += $"<div>{e.columnType} </div> ";
                ViewBag.ColumncolumnStatus += $"<div>{e.columnStatus} </div> ";
                ViewBag.ColumnnumberOfFloorsServed += $"<div>{e.numberOfFloorsServed} </div> ";
                ViewBag.Columninformation += $"<div>{e.information} </div> ";
                ViewBag.Columnotes += $"<div>{e.notes} </div>";

            }

            foreach (Elevator e in objResponse3)
            {
                ViewBag.ElevatorId += $"<div>{e.id} </div>";
                ViewBag.ElevatorcolumnId += $"<div>{e.columnId} </div> ";
                ViewBag.ElevatorserialNumber += $"<div>{e.serialNumber} </div> ";
                ViewBag.ElevatorelevatorModel += $"<div>{e.elevatorModel} </div> ";
                ViewBag.ElevatorelevatorType += $"<div>{e.elevatorType} </div> ";
                ViewBag.ElevatorelevatorStatus += $"<div>{e.elevatorStatus} </div> ";
                ViewBag.ElevatorcertificateOfInspection += $"<div>{e.certificateOfInspection} </div> ";
                ViewBag.Elevatorinformation += $"<div>{e.information} </div> ";
                ViewBag.Elevatornotes += $"<div>{e.notes} </div> ";
            }
            foreach (Buildings e in objResponse4)
            {
                ViewBag.Buildingsid += $"<div>{e.id}</div>";
                ViewBag.BuildingscustomerId += $"<div>{e.customerId} </div>";
                ViewBag.BuildingsadministratorFullName += $"<div>{e.administratorFullName} </div>";
                ViewBag.BuildingsadministratorEmail += $"<div>{e.administratorEmail} </div> ";
                ViewBag.BuildingsadministratorPhoneNumber += $"<div>{e.administratorPhoneNumber} </div> ";
                ViewBag.BuildingstechnicalContactFullName += $"<div>{e.administratorFullName} </div> ";
                ViewBag.BuildingstechnicalContactEmail += $"<div>{e.technicalContactEmail} </ div > ";
                ViewBag.BuildingstechnicalContactPhone += $"<div>{e.technicalContactPhone} </div> ";
            }
            foreach (Address e in objResponse5)
            {
                ViewBag.Addressid += $"<div>{e.id} </div> ";
                ViewBag.AddressnumberAndStreet += $"<div>{e.numberAndStreet} </div> ";
                ViewBag.AddresssuiteOrApartment += $"<div>{e.suiteOrApartment}</div>";
                ViewBag.Addresscity += $"<div>{e.city}</div>";
                ViewBag.AddresspostalCode += $"<div>{e.postalCode}</div>";
                ViewBag.Addresscountry += $"<div>{e.country}</div>";
                ViewBag.Addressnotes += $"<div>{e.notes}</div>";
                ViewBag.Addresslatitude += $"<div>{e.latitude}</div>";
                ViewBag.Addresslongitude += $"<div>{e.longitude}</div>";
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

        // define Address for json
        public class Address
        {
            public int id { get; set; }
            public object buildingId { get; set; }
            public int customerId { get; set; }
            public string typeOfAddress { get; set; }
            public string status { get; set; }
            public string entity { get; set; }
            public string numberAndStreet { get; set; }
            public string suiteOrApartment { get; set; }
            public string city { get; set; }
            public string postalCode { get; set; }
            public string country { get; set; }
            public string notes { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public object building { get; set; }
            public object customer { get; set; }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Customer
        {
            public int id { get; set; }
            public int userId { get; set; }
            public string companyName { get; set; }
            public string companyContactFullName { get; set; }
            public string companyContactPhone { get; set; }
            public string companyContactEmail { get; set; }
            public string companyDescription { get; set; }
            public string technicalAuthorityFullName { get; set; }
            public string technicalAuthorityPhoneNumber { get; set; }
            public string technicalManagerEmailService { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public int addressId { get; set; }
            public List<object> addresses { get; set; }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
