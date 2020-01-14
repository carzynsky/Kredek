using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArkadiuszCarzynskiLab6Zadanie.Models;

namespace ArkadiuszCarzynskiLab6Zadanie.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista urządzeń
        /// </summary>
        List<PhoneViewModel> phones;

        /// <summary>
        /// Konstruktor klasy HomeControlller
        /// </summary>
        public HomeController()
        {
            phones = new List<PhoneViewModel>();
            // Dodanie urządzeń od Apple
            phones.Add(new PhoneViewModel("Apple","iPhone 11", "Apple A13", 4, "150.90 x 75.70 x 8.30 mm", 194, 3059, "~/Content/Images/iphone11.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone X", "Apple A11", 3, "143.60 x 70.90 x 7.70 mm", 174, 3434, "~/Content/Images/iphonex.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 8", "Apple A11", 2, "138.40 x 67.30 x 7.30 mm", 148, 2056, "~/Content/Images/iphone8.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 7", "Apple A11", 2, "138.30 x 67.10 x 7.10 mm", 138, 1499, "~/Content/Images/iphone7.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 6s", "Apple A9", 2, "138.30 x 67.10 x 7.10 mm", 143, 1149, "~/Content/Images/iphone6s.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 6", "Apple A8", 2, "138.10 x 67.00 x 6.90 mm", 129, 999, "~/Content/Images/iphone6.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 5s", "Apple A7", 1, "123.80 x 58.60 x 7.60 mm", 112, 799, "~/Content/Images/iphone5s.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 5", "Apple A11", 1, "123.80 x 58.60 x 7.60 mm ", 112, 499, "~/Content/Images/iphone5.png"));
            phones.Add(new PhoneViewModel("Apple", "iPhone 4s", "Apple A5", 0.512, "115.20 x 58.60 x 9.30 mm", 140, 299, "~/Content/Images/iphone4s.png"));
            // Dodanie urządzeń od Samsunga
            phones.Add(new PhoneViewModel("Samsung", "Galaxy S10", "Exynos 9820", 8, "149.90 x 70.40 x 7.80 mm", 157, 2513, "~/Content/Images/galaxys10.png"));
            phones.Add(new PhoneViewModel("Samsung", "Galaxy S9", "Exynos 9810", 4, "147.70 x 68.70 x 8.50 mm", 163, 2094, "~/Content/Images/galaxys9.png"));
            phones.Add(new PhoneViewModel("Samsung", "Galaxy S8", "Exynos 8895", 4, "148.90 x 68.10 x 8.00 mm", 155, 1489, "~/Content/Images/galaxys8.png"));
            phones.Add(new PhoneViewModel("Samsung", "Galaxy S7", "Exynos 8890", 4, "142.40 x 69.60 x 7.90 mm", 152, 1095, "~/Content/Images/galaxys7.png"));
            phones.Add(new PhoneViewModel("Samsung", "Galaxy S6", "Exynos 7420", 3, "143.40 x 70.50 x 6.80 mm", 138, 799, "~/Content/Images/galaxys6.png"));
            // Dodanie urządzeń od Sony
            phones.Add(new PhoneViewModel("Sony", "Xperia 5", "Snapdragon 855", 6, "158.00 x 68.00 x 8.20 mm", 164, 2999, "~/Content/Images/xperia5.png"));
            phones.Add(new PhoneViewModel("Sony", "Xperia 1"," Snapdragon 855", 6, "167.00 x 72.00 x 8.20 mm", 178, 3696, "~/Content/Images/xperia1.png"));
            phones.Add(new PhoneViewModel("Sony", "Xperia 10", "Snapdragon 630", 3, "156.00 x 68.00 x 8.40 mm", 162, 999, "~/Content/Images/xperia10.png"));
            // Dodanie urządzeń od Xiaomi
            phones.Add(new PhoneViewModel("Xiaomi", "Redmi Note 8T", "Snapdragon 665", 4, "161.15 x 75.40 x 8.60 mm", 199, 700, "~/Content/Images/xiaomiredminote8t.png"));
            phones.Add(new PhoneViewModel("Xiaomi", "Redmi 8", "Snapdragon 439", 4, "156.48 x 75.41 x 9.40 mm", 188, 585, "~/Content/Images/xiaomiredmi8.png"));
            phones.Add(new PhoneViewModel("Xiaomi", "Redmi 7", "Snapdragon 632", 3, "158.73 x 75.58 x 8.47 mm", 180, 525, "~/Content/Images/xiaomiredmi7.png"));
            // Dodanie urządzeń od Huawei
            phones.Add(new PhoneViewModel("Huawei", "P30 Pro", "HiSilicon Kirin 980", 8, "158.00 x 73.40 x 8.41 mm", 192, 2516, "~/Content/Images/huaweip30pro.png"));
            phones.Add(new PhoneViewModel("Huawei", "P30", "HiSilicon Kirin 980", 6, "149.10 x 71.36 x 7.57 mm", 165, 1770, "~/Content/Images/huaweip30.png"));
            phones.Add(new PhoneViewModel("Huawei", "P20", "HiSilicon Kirin 970", 4, "149.10 x 70.80 x 7.65 mm", 165, 999, "~/Content/Images/huaweip20.png"));
        }

        /// <summary>
        /// Wyświetlenie listy producentów w bazie
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetListOfBrands()
        {
            List<string> brands = new List<string>();
            foreach(var brand in phones)
            {
                if(!brands.Contains(brand.Brand))
                {
                    brands.Add(brand.Brand);
                }
            }
            return View(brands);
        }

        /// <summary>
        /// Wyświetlenie listy telefonów w bazie
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetListOfAllPhones()
        {
            List<string> allPhones = new List<string>();
            foreach (var phone in phones)
            {
                allPhones.Add(phone.Model);
            }
            return View(allPhones);
        }

        /// <summary>
        /// Wyświetlenie listy telefonów danego producenta w bazie
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllPhonesByBrand(string brand)
        {
            List<PhoneViewModel> listOfPhonesByBrand = new List<PhoneViewModel>();
            foreach(var p in phones)
            {
                if (p.Brand.ToLower() == brand.ToLower())
                    listOfPhonesByBrand.Add(p);
            }
            
            ViewData["Title"] = listOfPhonesByBrand[0].Brand + "'s smartphones";
            return View(listOfPhonesByBrand);
        }

        /// <summary>
        /// Wyświetlenie informacji o danym telefonie z bazy
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPhoneByModel(string model)
        {
            PhoneViewModel phone = this.phones.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            return View(phone);
        }

        /// <summary>
        /// Wyświetlenie formularza zamówienia telefonu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OrderForm()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie informacji o zamówieniu po wypełnieniu formularza
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult OrderForm(OrderViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            string fullDevice = userData.Brand + " " + userData.Model + " (" + userData.Color + ")";
            ViewBag.UserName = fullName;
            ViewBag.OrderedDevice = fullDevice;
            return View("OrderFormSummary");
        }

        /// <summary>
        /// Wyświetlenie formularza dodania telefonu do bazy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddPhone()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie informacji o dodanym telefonie do bazy po wypełnieniu formularza
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddPhone(NewPhoneViewModel phone)
        {
            TempData["FullDevice"] = phone.Brand + " " + phone.Model;
            TempData["Specs"] = "Procesor " + phone.CPU +", " + phone.RAM + "GB RAM";
            TempData["Dimensions"] = "Dimensions: " + phone.Dimensions + "mm, waga: " + phone.Weight + "g";
            TempData["Price"] = "Price: " + phone.Price + "zł";
            return View("AddPhoneSummary");
        }

        /// <summary>
        /// Wyświetlenie formularza wysłania reklamacji
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SubmitComplaint()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie informacji o wysłanej reklamacji po wypełnieniu formularza
        /// </summary>
        /// <param name="complaint"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SubmitComplaint(ComplaintViewModel complaint)
        {
            return View("SubmitComplaintSummary", complaint);
        }

        /// <summary>
        /// Wyświetlenie głównej strony
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlnie informacji o prywtności
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie informacji o błędzie
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
