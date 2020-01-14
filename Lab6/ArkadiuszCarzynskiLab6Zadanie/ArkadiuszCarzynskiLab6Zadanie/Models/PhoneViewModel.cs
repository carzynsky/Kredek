using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab6Zadanie.Models
{
    public class PhoneViewModel
    {
        /// <summary>
        /// Konstrukto klasy PhoneViewModel
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="CPU"></param>
        /// <param name="RAM"></param>
        /// <param name="Dimensions"></param>
        /// <param name="Weight"></param>
        /// <param name="Price"></param>
        /// <param name="Picture"></param>
        public PhoneViewModel(string Brand, string Model, string CPU, double RAM, string Dimensions, int Weight, decimal Price, string Picture)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.CPU = CPU;
            this.RAM = RAM;
            this.Dimensions = Dimensions;
            this.Weight = Weight;
            this.Price = Price;
            this.Picture = Picture;
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
        public string CPU{ get; set; }
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
        public string Dimensions{ get; set; }
        /// <summary>
        /// Cena telefonu
        /// </summary>
        public decimal Price{ get; set; }
        /// <summary>
        /// Obrazek telefonu
        /// </summary>
        public string Picture { get; set; }
    }
}
