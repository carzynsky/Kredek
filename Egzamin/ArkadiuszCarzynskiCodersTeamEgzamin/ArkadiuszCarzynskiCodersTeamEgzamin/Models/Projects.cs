using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiCodersTeamEgzamin.Models
{
    class Projects
    {
        [Key]
        public int idProject { get; set; }
        public string name { get; set; }
        public int idProgrammer { get; set; }
        [ForeignKey("idProgrammer")]
        public virtual Programmers Programmers { get; set; }
    }
}
