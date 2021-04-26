using System;
using System.Collections.Generic;
using System.Text;
using MassiveWhitelist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MassiveWhitelist.Data.Mapping
{
    public class GeneralInformationUserMapping : IEntityTypeConfiguration<GeneralInformationUser>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<GeneralInformationUser> builder)
        {
            builder.HasKey(o => o.GeneralInformationUserId);
            builder.Property(o => o.GeneralInformationUserId).ValueGeneratedOnAdd();

            builder.Property(o => o.GeneralInformationValue).HasMaxLength(255);
        }
    }
}
