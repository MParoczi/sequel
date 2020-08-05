using Microsoft.EntityFrameworkCore;
using Sequel.Extensions;
using Sequel.Models;

namespace Sequel.Contexts
{
    public class SequelContext : DbContext
    {
        public SequelContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<ShowGenre> ShowGenres { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<Episode> Episodes { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<ShowCharacter> ShowCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureModelCreating();
        }
    }
}