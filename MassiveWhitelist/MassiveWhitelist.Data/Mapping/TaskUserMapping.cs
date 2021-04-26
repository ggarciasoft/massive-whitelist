using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class TaskUserMapping : IEntityTypeConfiguration<TaskUser>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<TaskUser> builder)
        {
            builder.HasKey(o => o.TaskUserId);
            builder.Property(o => o.TaskUserId).ValueGeneratedOnAdd();
        }
    }
}
