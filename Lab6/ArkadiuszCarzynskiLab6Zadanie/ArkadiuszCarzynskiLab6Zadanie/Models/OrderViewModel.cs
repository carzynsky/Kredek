using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab6Zadanie.Models
{
    public class OrderViewModel
    {
        /// <summary>
        /// Konstruktor klasy OrderViewModel
        /// </summary>
        public OrderViewModel()
        {

        }
        /// <summary>
        /// Producent telefonu
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Model telefonu
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Kolor telefonu
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Imię
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Mail
        /// </summary>
        public string Mail { get; set; }
    }
}
