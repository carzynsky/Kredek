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
    [Table("Clubs")]
    class Club
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage="Pole nazwa jest wymagane!")]
        [StringLength(100)]
        [DisplayName("Nazwa klubu")]
        public string Name{ get; set; }

        [DisplayName("Rok założenia")]
        public int FoundYear{ get; set; }

        [StringLength(100)]
        [DisplayName("Koszulki")]
        public string Kits { get; set; }

        public int StadiumId { get; set; }
        [ForeignKey("StadiumId")]
        public virtual Stadium Stadium{ get; set; }

        public int CoachId { get; set; }
        [ForeignKey("CoachId")]
        public virtual Coach Coach { get; set; }

        public virtual List<Footballer> Footballers { get; set; }
    }
}
