using LukaszDrozdzLab5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace LukaszDrozdzLab5.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// List of all cars
        /// </summary>

        /// <summary>
        /// Sql connection string
        /// </summary>
        readonly string connectionString = @"Data Source=DESKTOP-TSOGQMH\SQLEXPRESS;database=LukaszDrozdzLab5;Trusted_Connection=yes;";

        /// <summary>
        /// Constructor
        /// </summary>
        /// 

        List<CarViewModel> getAllCars()
        {
            List<CarViewModel> cars = new List<CarViewModel>();
            string query = @"SELECT * FROM CarsView";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        cars.Add(new CarViewModel(reader[0].ToString(), reader[1].ToString(), Int32.Parse(reader[2].ToString()), reader[3].ToString()));
                    reader.Close();
                }
                sqlConnection.Close();
            }
                return cars;
        }

        public HomeController()
        {

        }

        /// <summary>
        /// Get the list of manufacturers
        /// </summary>
        /// <returns></returns>
        public IActionResult GetListOfManufacturers()
        {
            List<string> manufacturers = getAllCars().GroupBy(car => car.Manufacturer).Select(car => car.First().Manufacturer).ToList();
            return View(manufacturers);
        }

        /// <summary>
        /// Get car by manufacturer
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCarByManufacturer(string manufacturer)
        {
            Console.WriteLine(manufacturer);
            List<CarViewModel> cars = getAllCars().Where(car => car.Manufacturer.Equals(manufacturer)).ToList();
            return View(cars);
        }

        /// <summary>
        /// Main page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Nice links
        /// </summary>
        /// <returns></returns>
        public IActionResult NiceLinks()
        {
            return View();
        }

        /// <summary>
        /// Dont know tbh
        /// </summary>
        /// <returns></returns>
        public IActionResult CheekieBreekie()
        {
            return View();
        }

        /// <summary>
        /// Presents user with contact form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Greets user with data from contact form
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Contact(ContactFormViewModel userData)
        {
            string query = @"INSERT INTO ContactForms(FirstName, LastName, Description) VALUES (@FirstName, @LastName, @Description)";
            Console.WriteLine("First name: "+userData.FirstName);

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar).Value = userData.FirstName;
                command.Parameters.Add("@LastName", System.Data.SqlDbType.NVarChar).Value = userData.LastName;
                command.Parameters.Add("@Description", System.Data.SqlDbType.NVarChar).Value = userData.Desc;
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }

            string fullName = userData.FirstName +" "+ userData.LastName;
            ViewBag.UserName = fullName;
            Console.WriteLine("Full name");
            Console.WriteLine(fullName);
            return View("ContactFormGreetings");
        }

        /// <summary>
        /// Get list of all models
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetListOfModels()
        {
            List<string> allModels = new List<string>();

            allModels = getAllCars().Select(car => car.Model).ToList();

            return View(allModels);
        }

        /// <summary>
        /// Get car by model
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IActionResult GetCarByModel(string model)
        {
            CarViewModel car = getAllCars().Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            return View(car);
        }

        /// <summary>
        /// Get the list of all cars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllCars()
        {
            return View(getAllCars());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
