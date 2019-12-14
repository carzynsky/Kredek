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
    [Table("Countries")]
    class Country
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Pole nazwa kraju jest wymagane!")]
        [StringLength(100)]
        [DisplayName("Nazwa kraju")]
        public string CountryName { get; set; }

        public virtual List<Footballer> Footballers { get; set; }
    }
}
