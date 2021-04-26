using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class GeneralInformationTypeMapping : IEntityTypeConfiguration<GeneralInformationType>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<GeneralInformationType> builder)
        {
            builder.HasKey(o => o.GeneralInformationTypeId);
            builder.Property(o => o.GeneralInformationTypeId).ValueGeneratedOnAdd();

            builder.Property(o => o.GeneralInformationTypeName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.GeneralInformationTypeDescription).HasMaxLength(255);
            builder.Property(o => o.GeneralInformationTypeKey).HasMaxLength(50).IsRequired();
        }
    }
}
