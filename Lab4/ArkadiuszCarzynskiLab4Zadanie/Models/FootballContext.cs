using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab4Zadanie.Models
{
    class FootballContext : DbContext
    {
        /// <summary>
        /// Konstruktor klasy FootballContext z odpowiednim dziedziczeniem
        /// </summary>
        public FootballContext() : base("AppContext")
        {

        }

        /// <summary>
        /// Odpowiednie propercje
        /// </summary>
        public virtual DbSet<Footballer> Footballers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }

    }
}
