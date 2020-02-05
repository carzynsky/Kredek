using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiCodersTeamEgzamin.Models
{
    class Programmers
    {
        [Key]
        public int idProgrammer { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int level { get; set; }
        public virtual List<Projects> Projects { get; set; }
    }
}
