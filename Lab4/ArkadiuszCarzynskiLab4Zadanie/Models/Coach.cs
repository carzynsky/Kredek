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
    class Coach
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Pole imie jest wymagane!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole nazwisko jest wymagane!")]
        [StringLength(150)]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Data urodzin")]
        public DateTime Birthdate { get; set; }

    }
}
