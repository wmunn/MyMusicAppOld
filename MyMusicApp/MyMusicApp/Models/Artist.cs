using System;
using System.Data.Entity;

namespace MyMusicApp.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }

    public class ArtistDBContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
    }
}