using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab6.Models
{
    public class ContactFormViewModel
    {
        /// <summary>
        /// Imię
        /// </summary>
        public string FirstName{get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Description { get; set; }
    }
}
