using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkadiuszCarzynskiLab7.Models;
using ArkadiuszCarzynskiLab7.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArkadiuszCarzynskiLab7.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService pizzaService;

        /// <summary>
        /// Konstruktor bezparametryczny
        /// </summary>
        public PizzaController(IPizzaService _pizzaService)
        {
            pizzaService = _pizzaService;
        }

        /// <summary>
        /// Metoda get pobierająca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = pizzaService.Get();
            return Ok(pizzas); // kod 200
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pizza pizza)
        {
            var id = pizzaService.Post(pizza);
            return Ok(id);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Pizza pizza, [FromRoute] int id)
        {
            if(id != pizza.Id)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccessful = pizzaService.Put(pizza, id);
                {
                    if(isUpdateSuccessful)
                    {
                        return NoContent();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = pizzaService.Delete(id);
            {
                if (isDeleteSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }

        }

    }
}