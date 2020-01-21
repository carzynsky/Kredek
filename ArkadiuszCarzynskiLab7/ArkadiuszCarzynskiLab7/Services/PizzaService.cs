using ArkadiuszCarzynskiLab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab7.Services
{
    public class PizzaService : IPizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>();
        public List<Pizza> Get()
        {
            return pizzas;
        }

        public int Post(Pizza pizza)
        {
            int id;
            if (pizzas.Count() == 0)
            {
                id = 0;
                pizza.Id = id;
            }
            else
            {
                id = pizzas.Max(x => x.Id);
                pizza.Id = ++id;
            }
            pizzas.Add(pizza);
            return id;
        }
        /// <summary>
        /// Aktualizacja pizzy o podanym id
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Pizza pizza, int Id)
        {
            // single o default jesli nie znjadzie wpisze null
            var pizzaToUpdate = pizzas.Where(x => x.Id.Equals(Id)).Single(); // dokladnie jedna pizza z listy, wyrzuca wyjatek jesli znajdzie wiecej niz jedna pizze
            if (pizzaToUpdate == null)
            {
                return false;
            }
            pizzaToUpdate.Name = pizza.Name;
            pizzaToUpdate.Cost = pizza.Cost;
            pizzaToUpdate.Description = pizza.Description;
            return true;
        }

        public bool Delete(int Id)
        {
            if(pizzas.Count() == 0)
            {
                return false;
            }
            var pizzaToDelete = pizzas.Where(x => x.Id.Equals(Id)).Single(); // dokladnie jedna pizza z listy, wyrzuca wyjatek jesli znajdzie wiecej niz jedna pizze
            if (pizzaToDelete == null)
            {
                return false;
            }
            pizzas.RemoveAt(Id);
            return true;
        }
    }
}
