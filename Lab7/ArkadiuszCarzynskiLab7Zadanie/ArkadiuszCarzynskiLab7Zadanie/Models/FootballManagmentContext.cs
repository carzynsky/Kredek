using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab7Zadanie.Models
{
    public class FootballManagmentContext:DbContext
    {
        public FootballManagmentContext(DbContextOptions<FootballManagmentContext> options) : base(options)
        {
                
        }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Club> Clubs { get; set; }
    }
}
