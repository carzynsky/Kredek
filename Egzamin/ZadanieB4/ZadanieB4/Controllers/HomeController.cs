using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZadanieB4.Models;

namespace ZadanieB4.Controllers
{
    public class HomeController : Controller
    {
        // Kontekst do bazy danych
        NORTHWNDContext _context;

        public HomeController(NORTHWNDContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Poczatkowy formularz
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Dodanie do bazy danych
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(Customers customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
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
