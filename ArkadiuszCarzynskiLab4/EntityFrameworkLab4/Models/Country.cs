using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab4.Models
{
    class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nazwa kraju")]
        public string Name { get; set; }

        [DisplayName("Rekord kraju")]
        public float CountryRecord { get; set; }
        public virtual List<Jumper> Jumpers{ get; set; }
    }
}
