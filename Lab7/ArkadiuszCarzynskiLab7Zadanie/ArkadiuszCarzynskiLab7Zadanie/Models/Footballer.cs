using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab7Zadanie.Models
{
    public class Footballer
    {
        public int Id{ get; set; }
        public string FirstName {get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string ClubName { get; set; }
    }
}
