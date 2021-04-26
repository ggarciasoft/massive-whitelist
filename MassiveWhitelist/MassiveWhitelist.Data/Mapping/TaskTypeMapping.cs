using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class TaskTypeMapping : IEntityTypeConfiguration<TaskType>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            builder.HasKey(o => o.TaskTypeId);
            builder.Property(o => o.TaskTypeId).ValueGeneratedOnAdd();

            builder.Property(o => o.TaskTypeName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.TaskTypeDescription).HasMaxLength(255);
            builder.Property(o => o.TaskTypeKey).HasMaxLength(50).IsRequired();
        }
    }
}
