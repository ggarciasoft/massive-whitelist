using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class TaskInformationMapping : IEntityTypeConfiguration<TaskInformation>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<TaskInformation> builder)
        {
            builder.HasKey(o => o.TaskInformationId);
            builder.Property(o => o.TaskInformationId).ValueGeneratedOnAdd();

            builder.Property(o => o.TaskInformationName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.TaskInformationDescription).HasMaxLength(255);
            builder.Property(o => o.TaskKey).HasMaxLength(255).IsRequired();
        }
    }
}
