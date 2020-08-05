using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Sequel.Contexts;
using Sequel.Contexts.Contracts;
using Sequel.Contexts.Repositories;

namespace Sequel.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlConnection(this IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("SEQUEL_CONNECTION_STRING");

            services.AddDbContext<SequelContext>(cfg =>
                cfg.UseNpgsql(connectionString ?? throw new NpgsqlException()));
        }
        
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IShowRepository, ShowRepository>();
            services.AddScoped<IShowGenreRepository, ShowGenreRepository>();
            services.AddScoped<ISeasonRepository, SeasonRepository>();
            services.AddScoped<IEpisodeRepository, EpisodeRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IShowCharacterRepository, ShowCharacterRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}