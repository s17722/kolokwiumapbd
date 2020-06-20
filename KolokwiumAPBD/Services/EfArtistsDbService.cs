using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumAPBD.Models;

namespace KolokwiumAPBD.Services
{
    public class EfArtistsDbService : IArtistsDbService
    {
        private readonly ArtistDbContext _context;
        public EfArtistsDbService(ArtistDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Artist_Event> GetEvents(int idArtist)
        {
            ICollection<Artist_Event> events;
            events = _context.ArtistEvent
                       .Where(z => z.Artist.IdArtist == idArtist)
                       .ToList();
            var artist = _context.Artists.Find(idArtist);

              return events;
        }

        public void UpdateEvent(int idArtist, int idEvent, DateTime pd)
        {
            var deadline = _context.Events.Find(idEvent).EndDate;

            var ae = _context.ArtistEvent.Find(idArtist, idEvent);

            var check = DateTime.Compare(deadline, pd);

            if (check > 0) { 
            ae.PerformanceDate = pd;
            _context.SaveChanges(); }
        }
    }
}
