using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiCodersTeamEgzamin.Models
{
    class ProgrammingContext : DbContext
    {
        /// <summary>
        /// Konstruktor klasy ProgrammingContext dziedziczący po konstruktorze klasy bazowej
        /// </summary>
        public ProgrammingContext() : base("AppContext")
        {

        }
        // Odpowiednie propercje dla zbioru elementów tabel Programmers i Projects
        public virtual DbSet<Programmers> Programmers { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
    }
}
