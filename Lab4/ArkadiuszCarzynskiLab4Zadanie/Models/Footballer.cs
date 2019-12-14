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
    [Table("Footballers")]
    class Footballer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole imię jest wymagane!")]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole nazwisko jest wymagane!")]
        [StringLength(250)]
        [DisplayName("Nazwisko")]
        public string LastName{ get; set; }

        [DisplayName("Data urodzin")]
        public DateTime Birthdate { get; set; }


        public int ClubId { get; set; }
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }


    }
}
