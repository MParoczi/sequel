using Microsoft.EntityFrameworkCore;
using Sequel.Models;

namespace Sequel.Extensions
{
    public static class ContextExtension
    {
        public static void ConfigureModelCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ShowGenre>()
                .HasOne(sg => sg.Show)
                .WithMany(s => s.ShowGenres)
                .HasForeignKey(sg => sg.ShowId);

            modelBuilder
                .Entity<ShowGenre>()
                .HasOne(sg => sg.Genre)
                .WithMany(s => s.ShowGenres)
                .HasForeignKey(sg => sg.GenreId);

            modelBuilder
                .Entity<Season>()
                .HasOne(s => s.Show)
                .WithMany(s => s.Seasons)
                .HasForeignKey(s => s.ShowId);

            modelBuilder
                .Entity<Episode>()
                .HasOne(e => e.Season)
                .WithMany(s => s.Episodes)
                .HasForeignKey(e => e.SeasonId);

            modelBuilder
                .Entity<ShowCharacter>()
                .HasOne(sc => sc.Actor)
                .WithMany(a => a.ShowCharacters)
                .HasForeignKey(sc => sc.ActorId);

            modelBuilder
                .Entity<ShowCharacter>()
                .HasOne(sc => sc.Show)
                .WithMany(s => s.ShowCharacters)
                .HasForeignKey(sc => sc.ShowId);
        }
    }
}