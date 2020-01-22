using ArkadiuszCarzynskiLab7Zadanie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab7Zadanie.Services
{
    public interface IClubService
    {
        DbSet<Club> Get();
        bool Post(Club club);
        bool Put(Club club, int Id);
        bool Delete(int Id);
    }
}
