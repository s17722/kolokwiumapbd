using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KolokwiumAPBD.Services;
using KolokwiumAPBD.Models;

namespace KolokwiumAPBD.Controllers
{
    [Route("api/artists")]
    [ApiController]

    public class ArtistsController : ControllerBase
    {

        private readonly IArtistsDbService _context;

        public ArtistsController(IArtistsDbService context)
        {
            _context = context;
        }

        [HttpGet("{idArtist}")]
        public IActionResult GetEvents(int idArtist)
        {
            return Ok(_context.GetEvents(idArtist));
        }

        [HttpPut("{idArtist, idEvent}")]
        public IActionResult UpdateEvent(int idArtist, int idEvent, DateTime pd)
        {
            _context.UpdateEvent(idArtist, idEvent, pd);
            return Ok("Zaktualizowano czas wystapienia");
        }
    }
}
