using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Models
{
    public class ArtistDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Organiser> Organisers { get; set; }

        public DbSet<Artist_Event> ArtistEvent { get; set; }

        public DbSet<Event_Organiser> EventOrganiser { get; set; }


        public ArtistDbContext()
        {

        }

        public ArtistDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artist_Event>()
                        .HasKey(z => new { z.IdArtist, z.IdEvent });

            modelBuilder.Entity<Event_Organiser>()
            .HasKey(z => new { z.IdEvent, z.IdOrganiser });
        }


    }
}
