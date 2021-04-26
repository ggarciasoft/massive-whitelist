using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MassiveWhitelist.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MassiveWhitelistDbContext>
    {
        /// <inheritdoc/>
        public MassiveWhitelistDbContext CreateDbContext(string[] args)
        {
            // Get environment
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // Build config
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MassiveWhitelist.Web"))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            // Get connection string
            var optionsBuilder = new DbContextOptionsBuilder<MassiveWhitelistDbContext>();
            var connectionString = config.GetConnectionString(nameof(MassiveWhitelistDbContext));
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("MassiveWhitelist.Data"));
            return new MassiveWhitelistDbContext(optionsBuilder.Options);
        }
    }
}
