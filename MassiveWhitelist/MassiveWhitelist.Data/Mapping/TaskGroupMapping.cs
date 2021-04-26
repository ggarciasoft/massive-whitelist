using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class TaskGroupMapping : IEntityTypeConfiguration<TaskGroup>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<TaskGroup> builder)
        {
            builder.HasKey(o => o.TaskGroupId);
            builder.Property(o => o.TaskGroupId).ValueGeneratedOnAdd();

            builder.Property(o => o.TaskGroupName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.TaskGroupDescription).HasMaxLength(255);
        }
    }
}
