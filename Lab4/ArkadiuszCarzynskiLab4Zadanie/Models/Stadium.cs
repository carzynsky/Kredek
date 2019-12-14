using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab4Zadanie.Models
{
    [Table("Stadiums")]
    class Stadium
    {
        [Key]
        public int StadiumId { get; set; }

        [Required(ErrorMessage = "Pole nazwa stadionu jest wymagane!")]
        [StringLength(150)]
        [DisplayName("Nazwa stadionu")]
        public string StadiumName { get; set; }

        [DisplayName("Pojemność")]
        public int Capacity { get; set; }

    }
}
