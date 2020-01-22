using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkadiuszCarzynskiLab7Zadanie.Models;
using ArkadiuszCarzynskiLab7Zadanie.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArkadiuszCarzynskiLab7Zadanie.Controllers
{
    [Route("api/footballer")]
    [ApiController]
    public class FootballerController : ControllerBase
    {
        private IFootballerService _footballerService;

        public FootballerController(IFootballerService footballerService)
        {
            _footballerService = footballerService;
        }

        /// <summary>
        /// Metoda get pobierająca wszystkich piłkarzy w bazie
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var footballers = _footballerService.Get();
            return Ok(footballers); // kod 200
        }

        /// <summary>
        /// Metoda Post dodająca piłkarza do bazy
        /// </summary>
        /// <param name="footballer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Footballer footballer)
        {
            var post = _footballerService.Post(footballer);
            if (post)
                return Ok();
            else
                return Conflict("Nie można podać takiej pozycji!");
        }

        /// <summary>
        /// Metoda Put edytująca piłkarza w bazie
        /// </summary>
        /// <param name="footballer"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Footballer footballer, [FromRoute] int id)
        {
            var isUpdateSuccessful = _footballerService.Put(footballer, id);

            if (isUpdateSuccessful)
            {
                return Ok();
            }

            else
            {
                return Conflict("Nie można zmienić podanych wartości!");
            }

        }

        /// <summary>
        /// Funkcja delete usuwająca piłkarza po danym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _footballerService.Delete(id);
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
