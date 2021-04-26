using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveWhitelist.Data
{
    public class MassiveWhitelistDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassiveWhitelistDbContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public MassiveWhitelistDbContext(DbContextOptions<MassiveWhitelistDbContext> options)
        : base(options)
        {
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MassiveWhitelistDbContext).Assembly);
        }
    }
}
