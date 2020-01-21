using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkadiuszCarzynskiLab7Zadanie.Models;
using Microsoft.EntityFrameworkCore;

namespace ArkadiuszCarzynskiLab7Zadanie.Services
{
    public class FootballerService : IFootballerService
    {
        /// <summary>
        /// Kontekst do bazy
        /// </summary>
        private FootballManagmentContext _context;

        /// <summary>
        /// Konstruktor klasy FootballerService z DI
        /// </summary>
        /// <param name="context"></param>
        public FootballerService(FootballManagmentContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Funkcja pobierająca wszystkich piłkarzy z bazy
        /// </summary>
        /// <returns></returns>
        public DbSet<Footballer> Get()
        {
            var x = _context.Footballers;
            return x;
        }

        /// <summary>
        /// Funkcja dodająca piłkarza do bazy
        /// </summary>
        /// <param name="footballer"></param>
        /// <returns></returns>
        public void Post(Footballer footballer)
        {
            List<string> possiblePositions = new List<string>()
            {
                "Goalkeeper",
                "Defender",
                "Midfielder",
                "Striker"
            };
            foreach(var x in possiblePositions)
            {
                if(footballer.Position == x)
                {
                    _context.Footballers.Add(footballer);
                    _context.SaveChanges();
                }                                
            }
        }

        /// <summary>
        /// Aktualizacja piłkarza o danym id, pozwala tylko na zmianę klubu i wieku piłkarza
        /// </summary>
        /// <param name="footballer"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Footballer footballer, int Id)
        {
            var footballerToUpdate = _context.Footballers.Where(x => x.Id.Equals(Id)).Single(); 
            if (footballerToUpdate == null)
            {
                return false;
            }
            if (footballerToUpdate.FirstName != footballer.FirstName || footballerToUpdate.LastName != footballer.LastName
                || footballerToUpdate.Position != footballer.Position)
                return false;

            footballerToUpdate.ClubName = footballer.ClubName;
            footballerToUpdate.Age = footballer.Age;
            _context.Footballers.Update(footballerToUpdate);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int Id)
        {
            var footballerToDelete = _context.Footballers.Where(x => x.Id.Equals(Id)).Single();

            if (footballerToDelete == null)
            {
                return false;
            }
            _context.Footballers.Remove(footballerToDelete);
            _context.SaveChanges();
            return true;
        }
    }
}
