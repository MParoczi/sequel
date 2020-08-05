using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Sequel.Contexts;

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
    }
}