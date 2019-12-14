using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab4Zadanie.Repositories
{
    interface IFootballGeneric<T> where T : class
    {
        /// <summary>
        /// Niezaimplementowane metody interfejsu IFootballGeneric
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
        IQueryable<T> Get();
        T GetById(int id);
        void DeleteById(int id);
        void Update(T entity);
        void Create(T entity);
        void Save();
    }
}
