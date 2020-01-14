using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab6Zadanie.Models
{
    public class NewPhoneViewModel
    {
        /// <summary>
        /// Konstruktor klasy NewPhoneViewModel
        /// </summary>
        public NewPhoneViewModel()
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
        /// Procesor telefonu
        /// </summary>
        public string CPU { get; set; }
        /// <summary>
        /// RAM
        /// </summary>
        public double RAM { get; set; }
        /// <summary>
        /// Waga telefonu
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Wymiary telefonu
        /// </summary>
        public string Dimensions { get; set; }
        /// <summary>
        /// Cena telefonu
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Obrazek telefonu
        /// </summary>
        public string Picture { get; set; }
    }
}
