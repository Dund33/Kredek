using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LukaszDrozdzLab4.Models;

namespace LukaszDrozdzLab4.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// List of all cars
        /// </summary>
        List<CarViewModel> allCars;

        /// <summary>
        /// Constructor
        /// </summary>
        public HomeController()
        {
            allCars = new List<CarViewModel>();
            allCars.Add(new CarViewModel("Focus", "Ford", 72000, "~/images/focus.png"));
            allCars.Add(new CarViewModel("Panzerkampfwagen VI", "Porsche", 900000, "~/images/pzkpfw.jpg"));
            allCars.Add(new CarViewModel("Civic", "Honda", 82000 ,"~/images/civic.png"));
            allCars.Add(new CarViewModel("Megane", "Renault", 720000, "~/images/megane.png"));

        }

        /// <summary>
        /// Get the list of manufacturers
        /// </summary>
        /// <returns></returns>
        public IActionResult GetListOfManufacturers()
        {
            List<string> manufacturers = allCars.GroupBy(car => car.Manufacturer).Select(car => car.First().Manufacturer).ToList();
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
            List<CarViewModel> cars = allCars.Where(car => car.Manufacturer.Equals(manufacturer)).ToList();
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
            Console.WriteLine("First name: "+userData.FirstName);
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

            allModels = allCars.Select(car => car.Model).ToList();

            return View(allModels);
        }

        /// <summary>
        /// Get car by model
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IActionResult GetCarByModel(string model)
        {
            CarViewModel car = allCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            return View(car);
        }

        /// <summary>
        /// Get the list of all cars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllCars()
        {
            return View(allCars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
