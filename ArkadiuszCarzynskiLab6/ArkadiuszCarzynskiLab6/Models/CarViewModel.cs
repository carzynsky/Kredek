using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab6.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// Model samochodu
        /// </summary>
        public string Model{ get; set; }
        /// <summary>
        /// Nazwa producenta
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price{ get; set; }
        /// <summary>
        /// Ścieżka do zdjęcia samochodu
        /// </summary>
        public string Photo { get; set; }

        public CarViewModel(string model, string manufacturer, decimal price, string photo)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Photo = photo;
        }
    }
}
