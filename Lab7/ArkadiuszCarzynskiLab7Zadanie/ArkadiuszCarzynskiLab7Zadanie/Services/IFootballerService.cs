using ArkadiuszCarzynskiLab7Zadanie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab7Zadanie.Services
{
    public interface IFootballerService
    {
        DbSet<Footballer> Get();
        void Post(Footballer footballer);
        bool Put(Footballer footballer, int Id);
        bool Delete(int Id);
    }
}
