using ArkadiuszCarzynskiLab4Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab4Zadanie.Repositories
{
    class FootballGeneric<T> : IFootballGeneric<T> where T : class
    {
        /// <summary>
        /// Kontekst bazy danych - połączenie z nią
        /// </summary>
        private readonly FootballContext _context;
        public FootballGeneric()
        {
            _context = new FootballContext();
        }

        /// <summary>
        /// Pobranie wszystkich danych z tabeli
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        /// <summary>
        /// Pobranie query z bazy
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Pobranie obiektu z bazy po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        /// <summary>
        /// Usunięcie rekordu po indeksie
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        /// <summary>
        /// Aktualizacja danych rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Dodanie nowego rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Zapisanie dokonanych zmian
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
