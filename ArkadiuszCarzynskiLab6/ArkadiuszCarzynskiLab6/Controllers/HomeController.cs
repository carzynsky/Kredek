using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArkadiuszCarzynskiLab6.Models;

namespace ArkadiuszCarzynskiLab6.Controllers
{
    public class HomeController : Controller
    {
        List<CarViewModel> cars;
        public HomeController()
        {
            cars = new List<CarViewModel>();
            cars.Add(new CarViewModel("Focus", "Ford", 72000, "~/Content/Images/focus.png"));
            cars.Add(new CarViewModel("Golf", "Volkswagen", 80000, "~/Content/Images/golf.png"));
            cars.Add(new CarViewModel("Civic", "Honda", 82000, "~/Content/Images/civic.png"));
            cars.Add(new CarViewModel("Megane", "Renault", 67000, "~/Content/Images/megane.png"));
        }
        public IActionResult GetAllCars()
        {
            return View(cars);
        }

        public IActionResult GetListOfModels()
        {
            // Lista modeli samochodów
            List<string> models = new List<string>();

            // PObranie każdego z samochodów w liście
            foreach(CarViewModel car in cars)
            {
                models.Add(car.Model);
            }

            // Przekazanie listy modeli do zwracanego widoku
            return View(models);
        }

        public IActionResult GetCarByModel(string model)
        {
            // Wyszukanie samochodu o danej nazwie modelu
            CarViewModel car = this.cars.Where(c => c.Model.ToLower() == model.ToLower()).FirstOrDefault();

            // Przekazanie widoku do samochodu zwracanego widoku
            return View(car);

        }

        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel formViewModel)
        {
            string fullName = formViewModel.FirstName + " " + formViewModel.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Index()
        {
            string name = "Arkadiusz Carzynski";
            return View("Index",name);
        }

        public IActionResult InterestingLinks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
