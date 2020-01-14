using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab6Zadanie.Models
{
    public class ComplaintViewModel
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ComplaintViewModel()
        {

        }

        /// <summary>
        /// Producent
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Model telefonu
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Opis reklamacji
        /// </summary>
        public string Description { get; set; }
    }
}
