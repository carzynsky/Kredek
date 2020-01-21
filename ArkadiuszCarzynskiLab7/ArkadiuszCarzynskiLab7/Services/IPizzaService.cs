using System.Collections.Generic;
using ArkadiuszCarzynskiLab7.Models;

namespace ArkadiuszCarzynskiLab7.Services
{
    public interface IPizzaService
    {
        List<Pizza> Get();
        int Post(Pizza pizza);
        bool Put(Pizza pizza, int Id);
        bool Delete(int Id);
    }
}