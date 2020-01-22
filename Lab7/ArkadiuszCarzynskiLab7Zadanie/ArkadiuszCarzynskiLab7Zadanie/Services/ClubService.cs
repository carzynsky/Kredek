using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkadiuszCarzynskiLab7Zadanie.Models;
using Microsoft.EntityFrameworkCore;

namespace ArkadiuszCarzynskiLab7Zadanie.Services
{
    public class ClubService : IClubService
    {
        /// <summary>
        /// Kontekst do bazy
        /// </summary>
        private FootballManagmentContext _context;

        /// <summary>
        /// Konstruktor klasy ClubService ze wstrzykniętym kontekstem
        /// </summary>
        /// <param name="context"></param>
        public ClubService(FootballManagmentContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Funkcja usuwająca klub o danym id z bazy i zwracająca informację o poprawności
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            var clubToDelete = _context.Clubs.Where(x => x.Id.Equals(Id)).Single();
            if(clubToDelete == null)
            {
                return false;
            }
            _context.Clubs.Remove(clubToDelete);
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Funkcja zwracająca wszystkie kluby z bazy
        /// </summary>
        /// <returns></returns>
        public DbSet<Club> Get()
        {
            var clubs = _context.Clubs;
            return clubs;
        }

        /// <summary>
        /// Funkcja dodająca klub do bazy, zwraca informację czy dodano
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        public bool Post(Club club)
        {
            if(club.Capacity >0 && club.Capacity <= 100000)
            {
                _context.Clubs.Add(club);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Funkcja edytująca klub z bazy, zwraca informację o poprawności
        /// </summary>
        /// <param name="club"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Club club, int Id)
        {
            var clubToUpdate = _context.Clubs.Where(x => x.Id.Equals(Id)).Single();
            if(clubToUpdate == null || club.ClubName != clubToUpdate.ClubName || club.Capacity <= 0 || club.Capacity > 100000)
            {
                return false;
            }

            clubToUpdate.Capacity = club.Capacity;
            clubToUpdate.StadiumName = club.StadiumName;
            _context.Clubs.Update(clubToUpdate);
            _context.SaveChanges();
            return true;
        }
    }
}
