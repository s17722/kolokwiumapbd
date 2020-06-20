using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumAPBD.Models;

namespace KolokwiumAPBD.Services
{
    public interface IArtistsDbService
    {
        //public IEnumerable<Event> GetEvents(int idArtist);
        public IEnumerable<Artist_Event> GetEvents(int idArtist);
        public void UpdateEvent(int idArtist, int idEvent, DateTime pd);
    }
}
