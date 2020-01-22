using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkadiuszCarzynskiLab7Zadanie.Models;
using ArkadiuszCarzynskiLab7Zadanie.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArkadiuszCarzynskiLab7Zadanie.Controllers
{
    [Route("api/club")]
    public class ClubController : Controller
    {
        private readonly IClubService _clubService;

        /// <summary>
        /// Kontroler klasy ClubController
        /// </summary>
        /// <param name="clubService"></param>
        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        /// <summary>
        /// Funkcja get, w której następuje pobranie wszystkich klubów z bazy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var clubs = _clubService.Get();
            return Ok(clubs);
        }

        /// <summary>
        /// Funkcja post, w której następuje dodanie klubu do bazy
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Club club)
        {
            var clubToPost = _clubService.Post(club);
            if(clubToPost)
            {
                return Ok();
            }
            else
            {
                return Conflict("Nie można utworzyć klubu o takich parametrach!");
            }

        }

        /// <summary>
        /// Funkcja put edytująca istniejący klub w bazie, zwraca informacje o poprawnosci
        /// </summary>
        /// <param name="club"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Club club, [FromRoute] int id)
        {
            var isUpdateSuccessful = _clubService.Put(club, id);

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
        /// Funkcja put, w której następuje usunięcie klubu z bazy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _clubService.Delete(id);
            if(isDeleteSuccessful)
            {
                return Ok();
            }
            else
            {
                return Conflict("Nie można usunąć!");
            }
        }
    }
}